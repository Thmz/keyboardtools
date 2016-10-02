using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace KeyboardNotifications
{
    public partial class NotificationForm : Form
    {

        private double maxOpacity = 0;
        Timer showTimer;

        public NotificationForm()
        {
            InitializeComponent();
            Opacity = 0;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            maxOpacity = Properties.Settings.Default.Opacity * 0.01;
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Math.Round((Screen.PrimaryScreen.WorkingArea.Width - this.Width) * 0.5));
            int y = Convert.ToInt32((Screen.PrimaryScreen.WorkingArea.Height) * KeyboardNotifications.Properties.Settings.Default.yPercent * 0.01);
            this.Location = new Point(x, y);

            Opacity = maxOpacity;      //first the opacity is 0
            Show();
        }

        public void ShowNotification(string text)
        {
            this.notificationText.Text = text;

            if (showTimer != null) // Timer was already running because of previous notification
                showTimer.Stop();

            //if (fadeTimer != null)
            //    fadeTimer.Stop();


            showTimer = new System.Windows.Forms.Timer();
            showTimer.Interval = KeyboardNotifications.Properties.Settings.Default.Duration;
            showTimer.Tick += new EventHandler(Timer_Tick);
            showTimer.Start();

            Opacity = maxOpacity;
            Show();
        }
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            showTimer.Stop();
            Hide();
        }

        /* Fadeout anim */
        Timer fadeTimer;
        private void NotificationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;    //cancel the event so the form won't be closed

            fadeTimer = new Timer();
            fadeTimer.Interval = 25;
            fadeTimer.Tick += new EventHandler(FadeOut);  //this calls the fade out function
            fadeTimer.Start();

            if (Opacity <= 0)  //if the form is completly transparent
                e.Cancel = false;   //resume the event - the program can be closed
        }

        void FadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                fadeTimer.Stop();    //if it is, we stop the timer
                Hide();   //and we try to close the form
            }
            else
                Opacity -= 0.25;
        }

        

        /* Rounded corners */
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }
        
        //private const int WS_EX_TOPMOST = 0x00000008;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams createParams = base.CreateParams;
        //        createParams.ExStyle |= WS_EX_TOPMOST;
        //        return createParams;
        //    }
        //}

        const int WS_EX_NOACTIVATE = 0x8000000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams ret = base.CreateParams;
                ret.ExStyle |= WS_EX_NOACTIVATE;
                return ret;
            }
        }



      
        //// Animation
        //public async void FadeIn(Form o, int interval = 80) 
        //{
        //    //Object is not fully invisible. Fade it in
        //    while (o.Opacity < 1.0)
        //    {
        //        await Task.Delay(interval);
        //        o.Opacity += 0.05;
        //    }
        //    o.Opacity = 1; //make fully visible       
        //}

        //public async void FadeOut(Form o, int interval = 80)
        //{
        //    //Object is fully visible. Fade it out
        //    while (o.Opacity > 0.0)
        //    {
        //        await Task.Delay(interval);
        //        o.Opacity -= 0.05;
        //    }
        //    o.Opacity = 0; //make fully invisible       
        //}

    }
}

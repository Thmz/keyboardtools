using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace KeyPopups
{
    public partial class Notif : Form
    {
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

        /* Rounded corners */
        

        public Notif(string text)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


            this.set(text);
            Show();
        }
           
        private void Notif_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Math.Round((Screen.PrimaryScreen.WorkingArea.Width - this.Width) * 0.5));
            int y = Convert.ToInt32((Screen.PrimaryScreen.WorkingArea.Height) * 0.66);
            this.Location = new Point(x, y);   
            Opacity = 0.1;      //first the opacity is 0
            Show();

            fadeTimer = new Timer();
            fadeTimer.Interval = 10;  //we'll increase the opacity every 10ms
            fadeTimer.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            fadeTimer.Start();
        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 0.7)
                fadeTimer.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.2;
        }

        /* Fadeout anim */
        Timer fadeTimer;
        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;    //cancel the event so the form won't be closed

            fadeTimer = new Timer();
            fadeTimer.Interval = 20;
            fadeTimer.Tick += new EventHandler(fadeOut);  //this calls the fade out function
            fadeTimer.Start();

            if (Opacity == 0)  //if the form is completly transparent
                e.Cancel = false;   //resume the event - the program can be closed
        }

        void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                fadeTimer.Stop();    //if it is, we stop the timer
                Close();   //and we try to close the form
            }
            else
                Opacity -= 0.20;
        }




        
        System.Windows.Forms.Timer t;

        public void set(string text)
        {
            this.notifText.Text = text;
            
            if (t != null) // Timer was already running because of previous notif
            {
                t.Stop();
            }

            if (fadeTimer != null)
            {
                fadeTimer.Stop();
            }

            t = new System.Windows.Forms.Timer();
            t.Interval = KeyPopups.Properties.Settings.Default.Duration;
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            // this.frm.FadeOut(this.frm, 80);
            t.Stop();
            this.Close();
            Program.n = null;
        }


      
        // Animation
        public async void FadeIn(Form o, int interval = 80) 
        {
            //Object is not fully invisible. Fade it in
            while (o.Opacity < 1.0)
            {
                await Task.Delay(interval);
                o.Opacity += 0.05;
            }
            o.Opacity = 1; //make fully visible       
        }

        public async void FadeOut(Form o, int interval = 80)
        {
            //Object is fully visible. Fade it out
            while (o.Opacity > 0.0)
            {
                await Task.Delay(interval);
                o.Opacity -= 0.05;
            }
            o.Opacity = 0; //make fully invisible       
        }

    }
}

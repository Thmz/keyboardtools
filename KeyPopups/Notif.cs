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

        private const int WS_EX_TOPMOST = 0x00000008;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= WS_EX_TOPMOST;
                return createParams;
            }
        }

        public Notif()
        {
          //  this.Visible = false;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


           // MessageBox.Show(Screen.PrimaryScreen.WorkingArea.Width.ToString());

          //  int x = Convert.ToInt32(Math.Round((Screen.PrimaryScreen.WorkingArea.Width - 100)*0.5));
           // int y = (Screen.PrimaryScreen.WorkingArea.Height) * 0.33;
            this.Location = new Point(900, 700);
          //  this.Opacity = 0;
           // FadeIn(this, 80);
        }





        GlobalKeyboardHook gHook;
        System.Windows.Forms.Timer t;

        private void Notif_Load(object sender, EventArgs e)
        {
           
            gHook = new GlobalKeyboardHook(); // Create a new GlobalKeyboardHook
            // Declare a KeyDown Event
            gHook.KeyDown += new KeyEventHandler(gHook_KeyDown);
            // Add the keys you want to hook to the HookedKeys list
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
                gHook.HookedKeys.Add(key);
            gHook.hook();
          //  Hide();
           // this.Visible = false;
        }


        // Handle the KeyDown Event
        public void gHook_KeyDown(object sender, KeyEventArgs e)
        {
            this.Visible = true;
            Show();
            if (isNeeded(e.KeyCode.ToString()))
            {
                changeText(e.KeyCode.ToString());
            }
            else
            {
                changeText("eeyo" + e.KeyCode.ToString());
            }


            if (t != null)
            {
                t.Stop();
            }

            t = new System.Windows.Forms.Timer();
            t.Interval = KeyPopups.Properties.Settings.Default.Duration; // specify interval time as you want
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
        }

        private void Notif_FormClosing(object sender, FormClosingEventArgs e)
        {
            gHook.unhook();
        }


        public void changeText(string text)
        {
            this.notifText.Text = text;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // this.frm.FadeOut(this.frm, 80);
           Hide();
        }

        private Boolean isNeeded(String text)
        {

            if (KeyPopups.Properties.Settings.Default.Fkeys)
            {
                string[] a = { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12" };
                if (a.Contains(text))
                    return true;
            }

            if (KeyPopups.Properties.Settings.Default.Home)
            {
                string[] a = { "Home", "End", "PageUp", "Next" };
                if (a.Contains(text))
                    return true;
            }

            if (KeyPopups.Properties.Settings.Default.Ins)
            {
                string[] a = { "Insert", "Del" };
                if (a.Contains(text))
                    return true;
            }

            if (KeyPopups.Properties.Settings.Default.Caps)
            {
                if (text == "Capital")
                    return true;
            }

            if (KeyPopups.Properties.Settings.Default.Caps)
            {
                if (text == "NumLock")
                    return true;
            }

            if (KeyPopups.Properties.Settings.Default.Tab)
            {
                if (text == "Tab")
                    return true;
            }

            if (KeyPopups.Properties.Settings.Default.Escape)
            {
                if (text == "Escape")
                    return true;
            }
            return false;
        }

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

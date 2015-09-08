using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPopups
{
    public partial class KPsettings : Form
    {
        public KPsettings()
        {
            InitializeComponent();
        }

        GlobalKeyboardHook gHook;
        Notif frm;
        System.Windows.Forms.Timer t;

        private void Form1_Load(object sender, EventArgs e)
        {
            gHook = new GlobalKeyboardHook(); // Create a new GlobalKeyboardHook
            // Declare a KeyDown Event
            gHook.KeyDown += new KeyEventHandler(gHook_KeyDown);
            // Add the keys you want to hook to the HookedKeys list
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
                gHook.HookedKeys.Add(key);
            gHook.hook();
            this.frm = new Notif();


            cbFkeys.Checked = KeyPopups.Properties.Settings.Default.Fkeys;

            cbHome.Checked = KeyPopups.Properties.Settings.Default.Home;
            cbIns.Checked = KeyPopups.Properties.Settings.Default.Ins;
            cbCaps.Checked = KeyPopups.Properties.Settings.Default.Caps;
            cbEscape.Checked = KeyPopups.Properties.Settings.Default.Escape;
            cbNumLock.Checked = KeyPopups.Properties.Settings.Default.NumLock;
            cbTab.Checked = KeyPopups.Properties.Settings.Default.Tab;


           //  .Checked = KeyPopups.Properties.Settings.Default.Fkeys;
            // Hide form on load
          //  this.WindowState = FormWindowState.Minimized;
          //  Hide();
        }

       
        //// Fix notif icon
        //private void Form1_Resize(object sender, EventArgs e)
        //{
  
        //    //if the form is minimized  
        //    //hide it from the task bar  
        //    //and show the system tray icon (represented by the NotifyIcon control)  
        //    if (this.WindowState == FormWindowState.Minimized)
        //    {
        //        Hide();
        //    }
        //}

        //private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    Show();
        //    this.WindowState = FormWindowState.Normal;
        //}  

       
        // Handle the KeyDown Event
        public void gHook_KeyDown(object sender, KeyEventArgs e)
        {






            this.frm.Show();


            if (isNeeded(e.KeyCode.ToString()))
            {
                frm.changeText(e.KeyCode.ToString());
            }
            else
            {
                frm.changeText("eeyo"+e.KeyCode.ToString());
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            gHook.unhook();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           // this.frm.FadeOut(this.frm, 80);
            this.frm.Hide();
        }


        private Boolean isNeeded(String text){

            if (KeyPopups.Properties.Settings.Default.Fkeys)
            {
                string[] a = { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12" };
                if (a.Contains(text))
                    return true;
            }

            if (KeyPopups.Properties.Settings.Default.Home)
            {
                string[] a = { "Home", "End", "PageUp", "Next"};
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




        private void cbFkeys_CheckedChanged(object sender, EventArgs e)
        {
            KeyPopups.Properties.Settings.Default.Fkeys = cbFkeys.Checked;  
        }

        private void cbHome_CheckedChanged(object sender, EventArgs e)
        {
            KeyPopups.Properties.Settings.Default.Home = cbHome.Checked;
        }

        private void cbIns_CheckedChanged(object sender, EventArgs e)
        {
            KeyPopups.Properties.Settings.Default.Ins = cbIns.Checked;
        }

        private void cbTab_CheckedChanged(object sender, EventArgs e)
        {
            KeyPopups.Properties.Settings.Default.Tab = cbTab.Checked;
        }

        private void cbCaps_CheckedChanged(object sender, EventArgs e)
        {
            KeyPopups.Properties.Settings.Default.Caps = cbCaps.Checked;
        }

        private void cbNumLock_CheckedChanged(object sender, EventArgs e)
        {
            KeyPopups.Properties.Settings.Default.NumLock = cbNumLock.Checked;
        }

        private void cbEscape_CheckedChanged(object sender, EventArgs e)
        {
            KeyPopups.Properties.Settings.Default.Escape = cbEscape.Checked;
        }

    }
}

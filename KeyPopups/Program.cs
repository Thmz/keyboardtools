using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPopups
{
    static class Program
    {

        static GlobalKeyboardHook gHook;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            using (NotifyIcon icon = new NotifyIcon())
            {
                
                icon.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
                icon.ContextMenu = new ContextMenu(new MenuItem[] {
                    new MenuItem("Options", (s, e) => {new KPsettings().Show();}),
                    new MenuItem("Exit", (s, e) => { Application.Exit(); }),
                 });


                gHook = new GlobalKeyboardHook(); // Create a new GlobalKeyboardHook
                // Declare a KeyDown Event
                gHook.KeyDown += new KeyEventHandler(gHook_KeyDown);
                // Add the keys you want to hook to the HookedKeys list
                foreach (Keys key in Enum.GetValues(typeof(Keys)))
                    gHook.HookedKeys.Add(key);
                gHook.hook();
                icon.Visible = true;

               // Application.Run();
                //Notif n = new Notif();
                Application.Run();
            }
        }

        public static Notif n;

        // Handle the KeyDown Event
        public static void gHook_KeyDown(object sender, KeyEventArgs e)
        {

            string text = e.KeyCode.ToString();
            if (!isNeeded(text))
                return;

            if (n == null)
            {
                n = new Notif(text);
            }
            else
            {
                n.set(text);
            }
        }

        private static Boolean isNeeded(String text)
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

    }
}

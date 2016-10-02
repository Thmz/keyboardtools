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
        static List<string> keys = new List<string>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            using (NotifyIcon icon = new NotifyIcon())
            {

                icon.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
                icon.ContextMenu = new ContextMenu(new MenuItem[] {
                    new MenuItem("Options", (s, e) => {new SettingsForm().Show(); }),
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

                Program.BuildKeyArray();

                Application.Run();
            }
        }

        public static NotificationForm notificationForm = new NotificationForm();

        public static void restartNotificationForm(){
            Program.notificationForm.Close();
            Program.notificationForm = new NotificationForm();
        }

        // Handle the KeyDown Event
        public static void gHook_KeyDown(object sender, KeyEventArgs e)
        {

            string text = e.KeyCode.ToString();
            if (isNeeded(text))
            {
                text = changeText(text);
                Program.notificationForm.ShowNotification(text);
            }
        }

        /// <summary>
        /// Change some keycode text to more common text which will be shown
        /// </summary>
        /// <param name="text">keycode text as string</param>
        /// <returns>string</returns>
        public static string changeText(string text)
        {
            switch (text)
            {
                case "Capital":
                    return "CapsLock";
                case "Next":
                    return "PageDown";
                default:
                    return text;
            }
        }

        /// <summary>
        /// Builds an array with stings of the keycodes that require a notificaiton
        /// </summary>
        public static void BuildKeyArray()
        {
            keys = new List<string>();

            if (KeyPopups.Properties.Settings.Default.Fkeys)
            {
                var temp = new string[] { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12" };
                keys.InsertRange(keys.Count, temp);
            }

<<<<<<< HEAD
            if (KeyPopups.Properties.Settings.Default.Home)
=======

            if (KeyboardNotifications.Properties.Settings.Default.Home)
>>>>>>> 45afed3... Replaced
            {
                var temp = new[] { "Home", "End", "PageUp", "Next" };
                keys.InsertRange(keys.Count, temp);
            }

            if (KeyPopups.Properties.Settings.Default.Ins)
            {
                keys.Add("Insert");
                keys.Add("Delete");
            }

            if (KeyPopups.Properties.Settings.Default.Caps)
            {
                keys.Add("Capital");
            }

<<<<<<< HEAD
            if (KeyPopups.Properties.Settings.Default.Caps)
=======
            if (KeyboardNotifications.Properties.Settings.Default.NumLock)
>>>>>>> 267148b... Fixed opacity and cleaned code
            {
                keys.Add("NumLock");
            }

            if (KeyPopups.Properties.Settings.Default.Tab)
            {
                keys.Add("Tab");
            }

            if (KeyPopups.Properties.Settings.Default.Escape)
            {
                keys.Add("Escape");
            }

        }

        /// <summary>
        /// Returns true if the given string text is an element of the keys array. 
        /// </summary>
        /// <param name="text">a string to search for</param>
        /// <returns>true if text is in de keys array</returns>
        private static Boolean isNeeded(String text)
        {
            return keys.Contains(text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPopups
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Form1());
            
            
            using (NotifyIcon icon = new NotifyIcon())
            {
                icon.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
                icon.ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Options", (s, e) => {new KPsettings().Show();}),
                new MenuItem("Exit", (s, e) => { Application.Exit(); }),
            });
                icon.Visible = true;

               // Application.Run();
                Notif n = new Notif();
                Application.Run();
            }
        }
       
    }
}

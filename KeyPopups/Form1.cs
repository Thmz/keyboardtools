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

        private void Form1_Load(object sender, EventArgs e)
        {
            cbFkeys.Checked = KeyPopups.Properties.Settings.Default.Fkeys;
            cbHome.Checked = KeyPopups.Properties.Settings.Default.Home;
            cbIns.Checked = KeyPopups.Properties.Settings.Default.Ins;
            cbCaps.Checked = KeyPopups.Properties.Settings.Default.Caps;
            cbEscape.Checked = KeyPopups.Properties.Settings.Default.Escape;
            cbNumLock.Checked = KeyPopups.Properties.Settings.Default.NumLock;
            cbTab.Checked = KeyPopups.Properties.Settings.Default.Tab;
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

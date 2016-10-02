using System;
using System.Windows.Forms;

namespace KeyboardNotifications
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            cbFkeys.Checked = KeyboardNotifications.Properties.Settings.Default.Fkeys;
            cbHome.Checked = KeyboardNotifications.Properties.Settings.Default.Home;
            cbIns.Checked = KeyboardNotifications.Properties.Settings.Default.Ins;
            cbCaps.Checked = KeyboardNotifications.Properties.Settings.Default.Caps;
            cbEscape.Checked = KeyboardNotifications.Properties.Settings.Default.Escape;
            cbNumLock.Checked = KeyboardNotifications.Properties.Settings.Default.NumLock;
            cbTab.Checked = KeyboardNotifications.Properties.Settings.Default.Tab;
            tbDuration.Text = KeyboardNotifications.Properties.Settings.Default.Duration.ToString();
            tbVertPos.Text = KeyboardNotifications.Properties.Settings.Default.yPercent.ToString();
        }


        private void cbFkeys_CheckedChanged(object sender, EventArgs e)
        {
            KeyboardNotifications.Properties.Settings.Default.Fkeys = cbFkeys.Checked;
            Program.BuildKeyArray();
        }

        private void cbHome_CheckedChanged(object sender, EventArgs e)
        {
            KeyboardNotifications.Properties.Settings.Default.Home = cbHome.Checked;
            Program.BuildKeyArray();
        }

        private void cbIns_CheckedChanged(object sender, EventArgs e)
        {
            KeyboardNotifications.Properties.Settings.Default.Ins = cbIns.Checked;
            Program.BuildKeyArray();
        }


        private void cbTab_CheckedChanged(object sender, EventArgs e)
        {
            KeyboardNotifications.Properties.Settings.Default.Tab = cbTab.Checked;
            Program.BuildKeyArray();
        }

        private void cbCaps_CheckedChanged(object sender, EventArgs e)
        {
            KeyboardNotifications.Properties.Settings.Default.Caps = cbCaps.Checked;
            Program.BuildKeyArray();
        }

        private void cbNumLock_CheckedChanged(object sender, EventArgs e)
        {
            KeyboardNotifications.Properties.Settings.Default.NumLock = cbNumLock.Checked;
            Program.BuildKeyArray();
        }

        private void cbEscape_CheckedChanged(object sender, EventArgs e)
        {
            KeyboardNotifications.Properties.Settings.Default.Escape = cbEscape.Checked;
            Program.BuildKeyArray();
        }

        private void tbDuration_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(tbDuration.Text, out value))
            {
                KeyboardNotifications.Properties.Settings.Default.Duration = value;
            }
            else
            {
                KeyboardNotifications.Properties.Settings.Default.Duration = 700;
            }
        }

        private void tbDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbVertPos_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(tbVertPos.Text, out value) && value <= 100 && value >= 0)
            {
                KeyboardNotifications.Properties.Settings.Default.yPercent = value;
            }
            else
            {
                KeyboardNotifications.Properties.Settings.Default.yPercent = 70;
            }
        }

        private void tbVertPos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            KeyboardNotifications.Properties.Settings.Default.Save();
        }




    }
}

namespace KeyPopups
{
    partial class KPsettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KPsettings));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cbFkeys = new System.Windows.Forms.CheckBox();
            this.cbHome = new System.Windows.Forms.CheckBox();
            this.cbIns = new System.Windows.Forms.CheckBox();
            this.cbTab = new System.Windows.Forms.CheckBox();
            this.cbCaps = new System.Windows.Forms.CheckBox();
            this.cbNumLock = new System.Windows.Forms.CheckBox();
            this.cbEscape = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Keyboard Notifications";
            this.notifyIcon.Visible = true;
            // 
            // cbFkeys
            // 
            this.cbFkeys.AutoSize = true;
            this.cbFkeys.Location = new System.Drawing.Point(12, 12);
            this.cbFkeys.Name = "cbFkeys";
            this.cbFkeys.Size = new System.Drawing.Size(54, 17);
            this.cbFkeys.TabIndex = 6;
            this.cbFkeys.Text = "Fkeys";
            this.cbFkeys.UseVisualStyleBackColor = true;
            this.cbFkeys.CheckedChanged += new System.EventHandler(this.cbFkeys_CheckedChanged);
            // 
            // cbHome
            // 
            this.cbHome.AutoSize = true;
            this.cbHome.Location = new System.Drawing.Point(12, 35);
            this.cbHome.Name = "cbHome";
            this.cbHome.Size = new System.Drawing.Size(156, 17);
            this.cbHome.TabIndex = 7;
            this.cbHome.Text = "Home/End/PgUp/PgDown";
            this.cbHome.UseVisualStyleBackColor = true;
            this.cbHome.CheckedChanged += new System.EventHandler(this.cbHome_CheckedChanged);
            // 
            // cbIns
            // 
            this.cbIns.AutoSize = true;
            this.cbIns.Location = new System.Drawing.Point(12, 58);
            this.cbIns.Name = "cbIns";
            this.cbIns.Size = new System.Drawing.Size(61, 17);
            this.cbIns.TabIndex = 8;
            this.cbIns.Text = "Ins/Del";
            this.cbIns.UseVisualStyleBackColor = true;
            this.cbIns.CheckedChanged += new System.EventHandler(this.cbIns_CheckedChanged);
            // 
            // cbTab
            // 
            this.cbTab.AutoSize = true;
            this.cbTab.Location = new System.Drawing.Point(12, 81);
            this.cbTab.Name = "cbTab";
            this.cbTab.Size = new System.Drawing.Size(45, 17);
            this.cbTab.TabIndex = 9;
            this.cbTab.Text = "Tab";
            this.cbTab.UseVisualStyleBackColor = true;
            this.cbTab.CheckedChanged += new System.EventHandler(this.cbTab_CheckedChanged);
            // 
            // cbCaps
            // 
            this.cbCaps.AutoSize = true;
            this.cbCaps.Location = new System.Drawing.Point(12, 104);
            this.cbCaps.Name = "cbCaps";
            this.cbCaps.Size = new System.Drawing.Size(50, 17);
            this.cbCaps.TabIndex = 10;
            this.cbCaps.Text = "Caps";
            this.cbCaps.UseVisualStyleBackColor = true;
            this.cbCaps.CheckedChanged += new System.EventHandler(this.cbCaps_CheckedChanged);
            // 
            // cbNumLock
            // 
            this.cbNumLock.AutoSize = true;
            this.cbNumLock.Location = new System.Drawing.Point(12, 127);
            this.cbNumLock.Name = "cbNumLock";
            this.cbNumLock.Size = new System.Drawing.Size(72, 17);
            this.cbNumLock.TabIndex = 11;
            this.cbNumLock.Text = "NumLock";
            this.cbNumLock.UseVisualStyleBackColor = true;
            this.cbNumLock.CheckedChanged += new System.EventHandler(this.cbNumLock_CheckedChanged);
            // 
            // cbEscape
            // 
            this.cbEscape.AutoSize = true;
            this.cbEscape.Location = new System.Drawing.Point(12, 150);
            this.cbEscape.Name = "cbEscape";
            this.cbEscape.Size = new System.Drawing.Size(62, 17);
            this.cbEscape.TabIndex = 12;
            this.cbEscape.Text = "Escape";
            this.cbEscape.UseVisualStyleBackColor = true;
            this.cbEscape.CheckedChanged += new System.EventHandler(this.cbEscape_CheckedChanged);
            // 
            // KPsettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 178);
            this.Controls.Add(this.cbEscape);
            this.Controls.Add(this.cbNumLock);
            this.Controls.Add(this.cbCaps);
            this.Controls.Add(this.cbTab);
            this.Controls.Add(this.cbIns);
            this.Controls.Add(this.cbHome);
            this.Controls.Add(this.cbFkeys);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KPsettings";
            this.Text = "KB Popups";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.CheckBox cbFkeys;
        private System.Windows.Forms.CheckBox cbHome;
        private System.Windows.Forms.CheckBox cbIns;
        private System.Windows.Forms.CheckBox cbTab;
        private System.Windows.Forms.CheckBox cbCaps;
        private System.Windows.Forms.CheckBox cbNumLock;
        private System.Windows.Forms.CheckBox cbEscape;
    }
}


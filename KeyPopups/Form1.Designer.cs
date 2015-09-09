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
            this.lblDuration = new System.Windows.Forms.Label();
            this.tbDuration = new System.Windows.Forms.TextBox();
<<<<<<< HEAD
=======
            this.lblVertPos = new System.Windows.Forms.Label();
            this.tbVertPos = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
>>>>>>> 133207b... Fixed settings save
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
            this.cbFkeys.Size = new System.Drawing.Size(57, 17);
            this.cbFkeys.TabIndex = 6;
            this.cbFkeys.Text = "F-keys";
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
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(12, 189);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(101, 13);
            this.lblDuration.TabIndex = 13;
            this.lblDuration.Text = "Notification duration";
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(15, 206);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(100, 20);
            this.tbDuration.TabIndex = 14;
            this.tbDuration.TextChanged += new System.EventHandler(this.tbDuration_TextChanged);
            // 
<<<<<<< HEAD
=======
            // lblVertPos
            // 
            this.lblVertPos.AutoSize = true;
            this.lblVertPos.Location = new System.Drawing.Point(12, 238);
            this.lblVertPos.Name = "lblVertPos";
            this.lblVertPos.Size = new System.Drawing.Size(109, 13);
            this.lblVertPos.TabIndex = 15;
            this.lblVertPos.Text = "Vertical position (in %)";
            // 
            // tbVertPos
            // 
            this.tbVertPos.Location = new System.Drawing.Point(15, 254);
            this.tbVertPos.Name = "tbVertPos";
            this.tbVertPos.Size = new System.Drawing.Size(100, 20);
            this.tbVertPos.TabIndex = 16;
            this.tbVertPos.TextChanged += new System.EventHandler(this.tbVertPos_TextChanged);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(15, 289);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 17;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
>>>>>>> 133207b... Fixed settings save
            // KPsettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(179, 243);
=======
            this.ClientSize = new System.Drawing.Size(181, 321);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbVertPos);
            this.Controls.Add(this.lblVertPos);
>>>>>>> 133207b... Fixed settings save
            this.Controls.Add(this.tbDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.cbEscape);
            this.Controls.Add(this.cbNumLock);
            this.Controls.Add(this.cbCaps);
            this.Controls.Add(this.cbTab);
            this.Controls.Add(this.cbIns);
            this.Controls.Add(this.cbHome);
            this.Controls.Add(this.cbFkeys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox tbDuration;
<<<<<<< HEAD
=======
        private System.Windows.Forms.Label lblVertPos;
        private System.Windows.Forms.TextBox tbVertPos;
        private System.Windows.Forms.Button btSave;
>>>>>>> 133207b... Fixed settings save
    }
}


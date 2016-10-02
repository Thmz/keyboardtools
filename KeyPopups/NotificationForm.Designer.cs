namespace KeyboardNotifications
{
    partial class NotificationForm
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
            this.notificationText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notifText
            // 
            this.notificationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.notificationText.Location = new System.Drawing.Point(12, 9);
            this.notificationText.Name = "notifText";
            this.notificationText.Size = new System.Drawing.Size(168, 46);
            this.notificationText.TabIndex = 0;
            this.notificationText.Text = "F1";
            this.notificationText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Notif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(192, 64);
            this.Controls.Add(this.notificationText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(850, 800);
            this.Name = "Notif";
            this.Opacity = 0.7D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Notif";
            this.TopMost = true;
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotificationForm_FormClosing);
            this.Load += new System.EventHandler(this.NotificationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label notificationText;
    }
}
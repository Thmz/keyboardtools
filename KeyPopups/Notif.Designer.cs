namespace KeyPopups
{
    partial class Notif
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
            this.notifText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notifText
            // 
            this.notifText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.notifText.Location = new System.Drawing.Point(12, 22);
            this.notifText.Name = "notifText";
            this.notifText.Size = new System.Drawing.Size(455, 39);
            this.notifText.TabIndex = 0;
            this.notifText.Text = "F1";
            this.notifText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.notifText.Click += new System.EventHandler(this.label1_Click);
            // 
            // Notif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(488, 84);
            this.Controls.Add(this.notifText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(850, 800);
            this.Name = "Notif";
            this.Opacity = 0.5D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Notif";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Notif_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label notifText;
    }
}
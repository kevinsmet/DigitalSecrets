namespace FrontEndDigitalSecrets {
    partial class SecretBox {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.UploadASecret = new System.Windows.Forms.Button();
            this.ViewSecretOfTheDay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UploadASecret
            // 
            this.UploadASecret.ForeColor = System.Drawing.Color.Black;
            this.UploadASecret.Location = new System.Drawing.Point(18, 55);
            this.UploadASecret.Name = "UploadASecret";
            this.UploadASecret.Size = new System.Drawing.Size(141, 42);
            this.UploadASecret.TabIndex = 0;
            this.UploadASecret.Text = "Upload a secret";
            this.UploadASecret.UseVisualStyleBackColor = true;
            this.UploadASecret.Click += new System.EventHandler(this.AddASecret_Click);
            // 
            // ViewSecretOfTheDay
            // 
            this.ViewSecretOfTheDay.Location = new System.Drawing.Point(255, 55);
            this.ViewSecretOfTheDay.Name = "ViewSecretOfTheDay";
            this.ViewSecretOfTheDay.Size = new System.Drawing.Size(141, 42);
            this.ViewSecretOfTheDay.TabIndex = 1;
            this.ViewSecretOfTheDay.Text = "View secret of the day";
            this.ViewSecretOfTheDay.UseVisualStyleBackColor = true;
            this.ViewSecretOfTheDay.Click += new System.EventHandler(this.ViewSecretOfTheDay_Click);
            // 
            // SecretBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 153);
            this.Controls.Add(this.ViewSecretOfTheDay);
            this.Controls.Add(this.UploadASecret);
            this.Name = "SecretBox";
            this.Text = "SecretBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UploadASecret;
        private System.Windows.Forms.Button ViewSecretOfTheDay;
    }
}
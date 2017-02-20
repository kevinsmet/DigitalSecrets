namespace FrontEndDigitalSecrets.Forms {
    partial class UploadSecretView {
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.SecretDescription = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.Upload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(359, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 289);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(424, 327);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(213, 20);
            this.txtDescription.TabIndex = 0;
            this.txtDescription.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SecretDescription
            // 
            this.SecretDescription.AutoSize = true;
            this.SecretDescription.Location = new System.Drawing.Point(356, 334);
            this.SecretDescription.Name = "SecretDescription";
            this.SecretDescription.Size = new System.Drawing.Size(60, 13);
            this.SecretDescription.TabIndex = 2;
            this.SecretDescription.Text = "Description";
            this.SecretDescription.Click += new System.EventHandler(this.Upload_Click);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(356, 392);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(55, 13);
            this.FirstName.TabIndex = 3;
            this.FirstName.Text = "First name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(424, 385);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(213, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(356, 453);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(56, 13);
            this.LastName.TabIndex = 5;
            this.LastName.Text = "Last name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(424, 446);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(213, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(425, 516);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(212, 49);
            this.Upload.TabIndex = 3;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click_1);
            // 
            // UploadSecretView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 577);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.SecretDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UploadSecretView";
            this.Text = "UploadSecretView";
            this.Load += new System.EventHandler(this.UploadSecretView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label SecretDescription;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button Upload;
    }
}
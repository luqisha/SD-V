namespace CSE3200_Offline_190104140
{
    partial class Form2
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.GPATexbox = new System.Windows.Forms.Label();
            this.FTexbox = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TitleLabel.Location = new System.Drawing.Point(315, 39);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(187, 32);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "GPA Calculator";
            this.TitleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // GPATexbox
            // 
            this.GPATexbox.AutoSize = true;
            this.GPATexbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GPATexbox.Location = new System.Drawing.Point(91, 203);
            this.GPATexbox.Name = "GPATexbox";
            this.GPATexbox.Size = new System.Drawing.Size(380, 28);
            this.GPATexbox.TabIndex = 1;
            this.GPATexbox.Text = "Your acquired GPA for this semester is ";
            this.GPATexbox.Click += new System.EventHandler(this.GPATexbox_Click);
            // 
            // FTexbox
            // 
            this.FTexbox.AutoSize = true;
            this.FTexbox.Location = new System.Drawing.Point(105, 206);
            this.FTexbox.Name = "FTexbox";
            this.FTexbox.Size = new System.Drawing.Size(0, 25);
            this.FTexbox.TabIndex = 2;
            this.FTexbox.Click += new System.EventHandler(this.label3_Click);
            // 
            // BackButton
            // 
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(643, 378);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(132, 47);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Go Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(91, 153);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(112, 28);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Welcome! ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.FTexbox);
            this.Controls.Add(this.GPATexbox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLabel;
        private Label GPATexbox;
        private Label FTexbox;
        private Button BackButton;
        private Label NameLabel;
    }
}
namespace matomonial_management_system
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.PasswordLable = new System.Windows.Forms.Label();
            this.SIgnIN = new System.Windows.Forms.Button();
            this.singup = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userControlBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(278, 190);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 16);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "Email";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(281, 209);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(267, 20);
            this.emailBox.TabIndex = 2;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(281, 260);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(267, 20);
            this.passwordBox.TabIndex = 4;
            // 
            // PasswordLable
            // 
            this.PasswordLable.AutoSize = true;
            this.PasswordLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLable.Location = new System.Drawing.Point(278, 241);
            this.PasswordLable.Name = "PasswordLable";
            this.PasswordLable.Size = new System.Drawing.Size(67, 16);
            this.PasswordLable.TabIndex = 3;
            this.PasswordLable.Text = "Password";
            // 
            // SIgnIN
            // 
            this.SIgnIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIgnIN.Location = new System.Drawing.Point(281, 297);
            this.SIgnIN.Name = "SIgnIN";
            this.SIgnIN.Size = new System.Drawing.Size(266, 32);
            this.SIgnIN.TabIndex = 5;
            this.SIgnIN.Text = "Sign In";
            this.SIgnIN.UseVisualStyleBackColor = true;
            this.SIgnIN.Click += new System.EventHandler(this.button1_Click);
            // 
            // singup
            // 
            this.singup.AutoSize = true;
            this.singup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singup.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.singup.Location = new System.Drawing.Point(492, 332);
            this.singup.Name = "singup";
            this.singup.Size = new System.Drawing.Size(55, 16);
            this.singup.TabIndex = 7;
            this.singup.Text = "Sign Up";
            this.singup.Click += new System.EventHandler(this.singup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "User Control";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // userControlBox
            // 
            this.userControlBox.FormattingEnabled = true;
            this.userControlBox.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.userControlBox.Location = new System.Drawing.Point(281, 166);
            this.userControlBox.Name = "userControlBox";
            this.userControlBox.Size = new System.Drawing.Size(267, 21);
            this.userControlBox.TabIndex = 9;
            this.userControlBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControlBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.singup);
            this.Controls.Add(this.SIgnIN);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.PasswordLable);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.forgetbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label PasswordLable;
        private System.Windows.Forms.Button SIgnIN;
        private System.Windows.Forms.Label singup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox userControlBox;
    }
}


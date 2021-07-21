
namespace Cafe_Management_Mini_Project
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.llNewCustomer = new System.Windows.Forms.LinkLabel();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.llAdmin = new System.Windows.Forms.LinkLabel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.llForgot_password = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(11, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN IN";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUsername.Location = new System.Drawing.Point(143, 170);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(171, 45);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPassword.Location = new System.Drawing.Point(143, 230);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(160, 45);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // llNewCustomer
            // 
            this.llNewCustomer.AutoSize = true;
            this.llNewCustomer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.llNewCustomer.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llNewCustomer.Location = new System.Drawing.Point(99, 437);
            this.llNewCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llNewCustomer.Name = "llNewCustomer";
            this.llNewCustomer.Size = new System.Drawing.Size(276, 25);
            this.llNewCustomer.TabIndex = 3;
            this.llNewCustomer.TabStop = true;
            this.llNewCustomer.Text = "New Customer?Click here";
            this.llNewCustomer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llNewCustomer_LinkClicked);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Plum;
            this.buttonSubmit.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSubmit.Location = new System.Drawing.Point(408, 344);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(117, 42);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // llAdmin
            // 
            this.llAdmin.AutoSize = true;
            this.llAdmin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.llAdmin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llAdmin.Location = new System.Drawing.Point(644, 437);
            this.llAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llAdmin.Name = "llAdmin";
            this.llAdmin.Size = new System.Drawing.Size(195, 25);
            this.llAdmin.TabIndex = 5;
            this.llAdmin.TabStop = true;
            this.llAdmin.Text = "Admin?Click here";
            this.llAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAdmin_LinkClicked);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsername.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(331, 188);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(266, 27);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.Text = "8668446202";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPassword.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(331, 247);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(266, 27);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "Sarvesh";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExit.Location = new System.Drawing.Point(829, 24);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 40);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // llForgot_password
            // 
            this.llForgot_password.AutoSize = true;
            this.llForgot_password.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.llForgot_password.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llForgot_password.Location = new System.Drawing.Point(513, 288);
            this.llForgot_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llForgot_password.Name = "llForgot_password";
            this.llForgot_password.Size = new System.Drawing.Size(190, 25);
            this.llForgot_password.TabIndex = 9;
            this.llForgot_password.TabStop = true;
            this.llForgot_password.Text = "Forgot password?";
            this.llForgot_password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llForgot_password_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::Cafe_Management_Mini_Project.Properties.Resources._41593;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 596);
            this.Controls.Add(this.llForgot_password);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.llAdmin);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.llNewCustomer);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.LinkLabel llNewCustomer;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.LinkLabel llAdmin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.LinkLabel llForgot_password;
    }
}


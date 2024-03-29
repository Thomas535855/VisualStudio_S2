namespace Backlogmanager
{
    partial class RegisterForm
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
            lblRegister = new Label();
            tboxUsername = new TextBox();
            tboxEmail = new TextBox();
            tboxPassword = new TextBox();
            btnRegister = new Button();
            lblUsername = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegister.Location = new Point(715, 27);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(92, 30);
            lblRegister.TabIndex = 0;
            lblRegister.Text = "Register";
            // 
            // tboxUsername
            // 
            tboxUsername.Location = new Point(393, 144);
            tboxUsername.Name = "tboxUsername";
            tboxUsername.Size = new Size(687, 23);
            tboxUsername.TabIndex = 1;
            // 
            // tboxEmail
            // 
            tboxEmail.Location = new Point(393, 246);
            tboxEmail.Name = "tboxEmail";
            tboxEmail.Size = new Size(687, 23);
            tboxEmail.TabIndex = 2;
            // 
            // tboxPassword
            // 
            tboxPassword.Location = new Point(393, 355);
            tboxPassword.Name = "tboxPassword";
            tboxPassword.PasswordChar = '*';
            tboxPassword.Size = new Size(687, 23);
            tboxPassword.TabIndex = 3;
            tboxPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(698, 443);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(133, 65);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register User";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += button1_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(393, 126);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 15);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(393, 228);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(393, 337);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1572, 724);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(btnRegister);
            Controls.Add(tboxPassword);
            Controls.Add(tboxEmail);
            Controls.Add(tboxUsername);
            Controls.Add(lblRegister);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegister;
        private TextBox tboxUsername;
        private TextBox tboxEmail;
        private TextBox tboxPassword;
        private Button btnRegister;
        private Label lblUsername;
        private Label lblEmail;
        private Label lblPassword;
    }
}
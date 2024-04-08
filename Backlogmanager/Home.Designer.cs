namespace Backlogmanager
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            btnRegister = new Button();
            btnHome = new Button();
            pnlChildForm = new Panel();
            btnProfile = new Button();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = SystemColors.ActiveCaption;
            pnlMenu.Controls.Add(btnProfile);
            pnlMenu.Controls.Add(btnRegister);
            pnlMenu.Controls.Add(btnHome);
            pnlMenu.Location = new Point(-5, -4);
            pnlMenu.Margin = new Padding(3, 4, 3, 4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1818, 140);
            pnlMenu.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.ButtonFace;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Location = new Point(131, 32);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(86, 65);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.ButtonFace;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Location = new Point(18, 32);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(86, 65);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // pnlChildForm
            // 
            pnlChildForm.Location = new Point(-5, 133);
            pnlChildForm.Margin = new Padding(3, 4, 3, 4);
            pnlChildForm.Name = "pnlChildForm";
            pnlChildForm.Size = new Size(1815, 1017);
            pnlChildForm.TabIndex = 1;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = SystemColors.ButtonFace;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Location = new Point(248, 32);
            btnProfile.Margin = new Padding(3, 4, 3, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(86, 65);
            btnProfile.TabIndex = 3;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1810, 1055);
            Controls.Add(pnlChildForm);
            Controls.Add(pnlMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Home";
            Text = "Form1";
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Button btnRegister;
        private Button btnHome;
        private Panel pnlChildForm;
        private Button btnProfile;
    }
}

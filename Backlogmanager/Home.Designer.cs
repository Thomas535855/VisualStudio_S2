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
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = SystemColors.ActiveCaption;
            pnlMenu.Controls.Add(btnRegister);
            pnlMenu.Controls.Add(btnHome);
            pnlMenu.Location = new Point(-4, -3);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1591, 105);
            pnlMenu.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(115, 24);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 49);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(16, 24);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(75, 49);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // pnlChildForm
            // 
            pnlChildForm.Location = new Point(-4, 100);
            pnlChildForm.Name = "pnlChildForm";
            pnlChildForm.Size = new Size(1588, 763);
            pnlChildForm.TabIndex = 1;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 861);
            Controls.Add(pnlChildForm);
            Controls.Add(pnlMenu);
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
    }
}

namespace Backlogmanager
{
    partial class OverviewForm
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
            lblPopular = new Label();
            panel1 = new Panel();
            pnlFriendlist = new Panel();
            lblFriendlist = new Label();
            pnlFriend = new Panel();
            pnlFriendlist.SuspendLayout();
            SuspendLayout();
            // 
            // lblPopular
            // 
            lblPopular.AutoSize = true;
            lblPopular.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPopular.Location = new Point(12, 33);
            lblPopular.Name = "lblPopular";
            lblPopular.Size = new Size(141, 25);
            lblPopular.TabIndex = 0;
            lblPopular.Text = "Popular games:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(12, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 259);
            panel1.TabIndex = 1;
            // 
            // pnlFriendlist
            // 
            pnlFriendlist.BackColor = Color.Teal;
            pnlFriendlist.Controls.Add(pnlFriend);
            pnlFriendlist.Controls.Add(lblFriendlist);
            pnlFriendlist.Location = new Point(1293, 0);
            pnlFriendlist.Name = "pnlFriendlist";
            pnlFriendlist.Size = new Size(281, 726);
            pnlFriendlist.TabIndex = 2;
            // 
            // lblFriendlist
            // 
            lblFriendlist.AutoSize = true;
            lblFriendlist.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFriendlist.ForeColor = SystemColors.ButtonFace;
            lblFriendlist.Location = new Point(19, 19);
            lblFriendlist.Name = "lblFriendlist";
            lblFriendlist.Size = new Size(96, 25);
            lblFriendlist.TabIndex = 0;
            lblFriendlist.Text = "Friendlist:";
            // 
            // pnlFriend
            // 
            pnlFriend.BackColor = Color.MintCream;
            pnlFriend.Location = new Point(19, 66);
            pnlFriend.Name = "pnlFriend";
            pnlFriend.Size = new Size(248, 89);
            pnlFriend.TabIndex = 1;
            // 
            // OverviewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1572, 724);
            Controls.Add(pnlFriendlist);
            Controls.Add(panel1);
            Controls.Add(lblPopular);
            Name = "OverviewForm";
            Text = "OverviewForm";
            pnlFriendlist.ResumeLayout(false);
            pnlFriendlist.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPopular;
        private Panel panel1;
        private Panel pnlFriendlist;
        private Panel pnlFriend;
        private Label lblFriendlist;
    }
}
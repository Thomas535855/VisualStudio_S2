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
            pnlFriendlist = new Panel();
            pnlFriend = new Panel();
            lblFriendlist = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            pnlFriendlist.SuspendLayout();
            SuspendLayout();
            // 
            // lblPopular
            // 
            lblPopular.AutoSize = true;
            lblPopular.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPopular.Location = new Point(42, 43);
            lblPopular.Name = "lblPopular";
            lblPopular.Size = new Size(176, 32);
            lblPopular.TabIndex = 0;
            lblPopular.Text = "Popular games:";
            // 
            // pnlFriendlist
            // 
            pnlFriendlist.BackColor = Color.Teal;
            pnlFriendlist.Controls.Add(pnlFriend);
            pnlFriendlist.Controls.Add(lblFriendlist);
            pnlFriendlist.Location = new Point(1478, 0);
            pnlFriendlist.Margin = new Padding(3, 4, 3, 4);
            pnlFriendlist.Name = "pnlFriendlist";
            pnlFriendlist.Size = new Size(321, 968);
            pnlFriendlist.TabIndex = 2;
            // 
            // pnlFriend
            // 
            pnlFriend.BackColor = Color.MintCream;
            pnlFriend.Location = new Point(22, 72);
            pnlFriend.Margin = new Padding(3, 4, 3, 4);
            pnlFriend.Name = "pnlFriend";
            pnlFriend.Size = new Size(283, 89);
            pnlFriend.TabIndex = 1;
            // 
            // lblFriendlist
            // 
            lblFriendlist.AutoSize = true;
            lblFriendlist.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFriendlist.ForeColor = SystemColors.ButtonFace;
            lblFriendlist.Location = new Point(22, 25);
            lblFriendlist.Name = "lblFriendlist";
            lblFriendlist.Size = new Size(119, 32);
            lblFriendlist.TabIndex = 0;
            lblFriendlist.Text = "Friendlist:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(307, 99);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(229, 345);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(42, 99);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 345);
            panel1.TabIndex = 1;
            // 
            // OverviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1797, 965);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlFriendlist);
            Controls.Add(panel1);
            Controls.Add(lblPopular);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OverviewForm";
            Text = "OverviewForm";
            pnlFriendlist.ResumeLayout(false);
            pnlFriendlist.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPopular;
        private Panel pnlFriendlist;
        private Panel pnlFriend;
        private Label lblFriendlist;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
    }
}
namespace WinFormsApp2
{
    partial class DashboardPetugas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardPetugas));
            splitContainer1 = new SplitContainer();
            btnLogout = new Button();
            btnRiwayat = new Button();
            btnInputMonitoring = new Button();
            btnDashboard = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(5, 5, 5, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel1.BackgroundImage");
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel1.Controls.Add(btnLogout);
            splitContainer1.Panel1.Controls.Add(btnRiwayat);
            splitContainer1.Panel1.Controls.Add(btnInputMonitoring);
            splitContainer1.Panel1.Controls.Add(btnDashboard);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel2.BackgroundImage");
            splitContainer1.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1300, 720);
            splitContainer1.SplitterDistance = 432;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.BackColor = Color.Firebrick;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(57, 616);
            btnLogout.Margin = new Padding(5, 5, 5, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(309, 64);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.BackColor = Color.Transparent;
            btnRiwayat.FlatStyle = FlatStyle.Flat;
            btnRiwayat.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnRiwayat.ForeColor = Color.White;
            btnRiwayat.ImageAlign = ContentAlignment.MiddleLeft;
            btnRiwayat.Location = new Point(57, 440);
            btnRiwayat.Margin = new Padding(5, 5, 5, 5);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(309, 72);
            btnRiwayat.TabIndex = 3;
            btnRiwayat.Text = "   Riwayat Monitoring";
            btnRiwayat.TextAlign = ContentAlignment.MiddleLeft;
            btnRiwayat.UseVisualStyleBackColor = false;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnInputMonitoring
            // 
            btnInputMonitoring.BackColor = Color.Transparent;
            btnInputMonitoring.FlatStyle = FlatStyle.Flat;
            btnInputMonitoring.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnInputMonitoring.ForeColor = Color.White;
            btnInputMonitoring.ImageAlign = ContentAlignment.MiddleLeft;
            btnInputMonitoring.Location = new Point(57, 352);
            btnInputMonitoring.Margin = new Padding(5, 5, 5, 5);
            btnInputMonitoring.Name = "btnInputMonitoring";
            btnInputMonitoring.Size = new Size(309, 72);
            btnInputMonitoring.TabIndex = 2;
            btnInputMonitoring.Text = "   Input Monitoring";
            btnInputMonitoring.TextAlign = ContentAlignment.MiddleLeft;
            btnInputMonitoring.UseVisualStyleBackColor = false;
            btnInputMonitoring.Click += btnInputMonitoring_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(57, 264);
            btnDashboard.Margin = new Padding(5, 5, 5, 5);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(309, 72);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "   Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(27, 352);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 270);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 26);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(217, 32);
            label1.TabIndex = 0;
            label1.Text = "Monitoring Hari Ini";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(27, 49);
            pictureBox1.Margin = new Padding(5, 5, 5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(620, 186);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // DashboardPetugas
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1300, 720);
            Controls.Add(splitContainer1);
            DoubleBuffered = true;
            Margin = new Padding(5, 5, 5, 5);
            Name = "DashboardPetugas";
            Text = "Form1";
            Load += DashboardPetugas_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnLogout;
        private Button btnRiwayat;
        private Button btnInputMonitoring;
        private Button btnDashboard;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}

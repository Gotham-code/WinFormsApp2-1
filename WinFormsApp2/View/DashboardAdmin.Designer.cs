namespace WinFormsApp2
{
    partial class DashboardAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        // Method untuk memasukkan Form ke dalam PanelKonten
        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdmin));
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            btnDashboard = new Button();
            btnTanaman = new Button();
            btnLahan = new Button();
            btnPetugas = new Button();
            btnLaporan = new Button();
            btnLogout = new Button();
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(405, 204);
            panel2.Name = "panel2";
            panel2.Size = new Size(214, 119);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(19, 8);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 0;
            label1.Text = "JUMLAH TANAMAN\r\n";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(91, 204);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 123);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(16, 8);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 1;
            label2.Text = "JUMLAH LAHAN";
            // 
            // btnDashboard
            // 
            btnDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(50, 160);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(220, 45);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "   Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnTanaman
            // 
            btnTanaman.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnTanaman.BackColor = Color.Transparent;
            btnTanaman.FlatStyle = FlatStyle.Flat;
            btnTanaman.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnTanaman.ForeColor = Color.White;
            btnTanaman.Location = new Point(50, 215);
            btnTanaman.Name = "btnTanaman";
            btnTanaman.Size = new Size(220, 45);
            btnTanaman.TabIndex = 4;
            btnTanaman.Text = "   Data Tanaman";
            btnTanaman.TextAlign = ContentAlignment.MiddleLeft;
            btnTanaman.UseVisualStyleBackColor = false;
            btnTanaman.Click += btnTanaman_Click;
            // 
            // btnLahan
            // 
            btnLahan.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnLahan.BackColor = Color.Transparent;
            btnLahan.FlatStyle = FlatStyle.Flat;
            btnLahan.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLahan.ForeColor = Color.White;
            btnLahan.Location = new Point(50, 270);
            btnLahan.Name = "btnLahan";
            btnLahan.Size = new Size(220, 45);
            btnLahan.TabIndex = 5;
            btnLahan.Text = "   Data Lahan";
            btnLahan.TextAlign = ContentAlignment.MiddleLeft;
            btnLahan.UseVisualStyleBackColor = false;
            btnLahan.Click += btnLahan_Click;
            // 
            // btnPetugas
            // 
            btnPetugas.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnPetugas.BackColor = Color.Transparent;
            btnPetugas.FlatStyle = FlatStyle.Flat;
            btnPetugas.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnPetugas.ForeColor = Color.White;
            btnPetugas.Location = new Point(50, 325);
            btnPetugas.Name = "btnPetugas";
            btnPetugas.Size = new Size(220, 45);
            btnPetugas.TabIndex = 6;
            btnPetugas.Text = "   Data Petugas";
            btnPetugas.TextAlign = ContentAlignment.MiddleLeft;
            btnPetugas.UseVisualStyleBackColor = false;
            btnPetugas.Click += btnPetugas_Click;
            // 
            // btnLaporan
            // 
            btnLaporan.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnLaporan.BackColor = Color.Transparent;
            btnLaporan.FlatStyle = FlatStyle.Flat;
            btnLaporan.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLaporan.ForeColor = Color.White;
            btnLaporan.Location = new Point(50, 380);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(220, 45);
            btnLaporan.TabIndex = 7;
            btnLaporan.Text = "   Laporan";
            btnLaporan.TextAlign = ContentAlignment.MiddleLeft;
            btnLaporan.UseVisualStyleBackColor = false;
            btnLaporan.Click += btnLaporan_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.BackColor = Color.Firebrick;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(50, 495);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(220, 40);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.Transparent;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackgroundImage = Properties.Resources.bg_kiri;
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel1.Controls.Add(btnDashboard);
            splitContainer1.Panel1.Controls.Add(btnLogout);
            splitContainer1.Panel1.Controls.Add(btnTanaman);
            splitContainer1.Panel1.Controls.Add(btnLaporan);
            splitContainer1.Panel1.Controls.Add(btnPetugas);
            splitContainer1.Panel1.Controls.Add(btnLahan);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel2.BackgroundImage");
            splitContainer1.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1035, 563);
            splitContainer1.SplitterDistance = 344;
            splitContainer1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(91, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(517, 131);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.NavajoWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1035, 563);
            Controls.Add(splitContainer1);
            DoubleBuffered = true;
            Name = "DashboardAdmin";
            Text = "Form1";
            Load += DashboardAdmin_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Button btnDashboard;
        private Button btnTanaman;
        private Button btnLahan;
        private Button btnPetugas;
        private Button btnLaporan;
        private Button btnLogout;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
    }
}

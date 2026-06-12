namespace WinFormsApp2.View
{
    partial class Laporan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laporan));
            txtPetugas = new TextBox();
            txtTanggal = new TextBox();
            cmbJenis = new ComboBox();
            btnTampilkanLaporan = new Button();
            btnPetugas = new Button();
            dgvLaporan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).BeginInit();
            SuspendLayout();
            // 
            // txtPetugas
            // 
            txtPetugas.Location = new Point(188, 59);
            txtPetugas.Name = "txtPetugas";
            txtPetugas.Size = new Size(125, 27);
            txtPetugas.TabIndex = 2;
            txtPetugas.Text = "Petugas";
            // 
            // txtTanggal
            // 
            txtTanggal.Location = new Point(44, 59);
            txtTanggal.Name = "txtTanggal";
            txtTanggal.Size = new Size(125, 27);
            txtTanggal.TabIndex = 3;
            txtTanggal.Text = "Tanggal";
            // 
            // cmbJenis
            // 
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Location = new Point(44, 112);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(125, 28);
            cmbJenis.TabIndex = 4;
            cmbJenis.Text = "Jenis";
            // 
            // btnTampilkanLaporan
            // 
            btnTampilkanLaporan.Location = new Point(109, 157);
            btnTampilkanLaporan.Name = "btnTampilkanLaporan";
            btnTampilkanLaporan.Size = new Size(180, 29);
            btnTampilkanLaporan.TabIndex = 5;
            btnTampilkanLaporan.Text = "TAMPILKAN  LAPORAN";
            btnTampilkanLaporan.UseVisualStyleBackColor = true;
            // 
            // btnPetugas
            // 
            btnPetugas.Location = new Point(342, 157);
            btnPetugas.Name = "btnPetugas";
            btnPetugas.Size = new Size(161, 29);
            btnPetugas.TabIndex = 6;
            btnPetugas.Text = "CETAK LAPORAN";
            btnPetugas.UseVisualStyleBackColor = true;
            // 
            // dgvLaporan
            // 
            dgvLaporan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaporan.Location = new Point(44, 211);
            dgvLaporan.Name = "dgvLaporan";
            dgvLaporan.RowHeadersWidth = 51;
            dgvLaporan.Size = new Size(521, 218);
            dgvLaporan.TabIndex = 7;
            // 
            // Laporan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(632, 450);
            Controls.Add(dgvLaporan);
            Controls.Add(btnPetugas);
            Controls.Add(btnTampilkanLaporan);
            Controls.Add(cmbJenis);
            Controls.Add(txtTanggal);
            Controls.Add(txtPetugas);
            DoubleBuffered = true;
            Name = "Laporan";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPetugas;
        private TextBox txtTanggal;
        private ComboBox cmbJenis;
        private Button button1;
        private Button button2;
        private Button btnTampilkanLaporan;
        private Button btnPetugas;
        private DataGridView dgvLaporan;
    }
}
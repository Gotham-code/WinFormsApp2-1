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
            cmbJenis = new ComboBox();
            btnTampilkanLaporan = new Button();
            btnPetugas = new Button();
            dgvLaporan = new DataGridView();
            periodeawal = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).BeginInit();
            SuspendLayout();
            // 
            // txtPetugas
            // 
            txtPetugas.Location = new Point(44, 59);
            txtPetugas.Name = "txtPetugas";
            txtPetugas.PlaceholderText = "Nama Petugas";
            txtPetugas.Size = new Size(125, 27);
            txtPetugas.TabIndex = 2;
            // 
            // cmbJenis
            // 
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Items.AddRange(new object[] { "Kopi", "Kakao" });
            cmbJenis.Location = new Point(44, 112);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(125, 28);
            cmbJenis.TabIndex = 4;
            cmbJenis.Text = "Jenis Tanaman";
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
            // periodeawal
            // 
            periodeawal.Location = new Point(253, 59);
            periodeawal.Name = "periodeawal";
            periodeawal.Size = new Size(250, 27);
            periodeawal.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(253, 112);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // Laporan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(632, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(periodeawal);
            Controls.Add(dgvLaporan);
            Controls.Add(btnPetugas);
            Controls.Add(btnTampilkanLaporan);
            Controls.Add(cmbJenis);
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
        private ComboBox cmbJenis;
        private Button button1;
        private Button button2;
        private Button btnTampilkanLaporan;
        private Button btnPetugas;
        private DataGridView dgvLaporan;
        private DateTimePicker periodeawal;
        private DateTimePicker dateTimePicker1;
    }
}
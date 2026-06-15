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
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).BeginInit();
            SuspendLayout();
            // 
            // txtPetugasandjiawndijbwjdbajdbwj
            // 
            txtPetugas.Location = new Point(72, 94);
            txtPetugas.Margin = new Padding(5, 5, 5, 5);
            txtPetugas.Name = "txtPetugas";
            txtPetugas.PlaceholderText = "Nama Petugas";
            txtPetugas.Size = new Size(201, 39);
            txtPetugas.TabIndex = 2;
            // 
            // cmbJenis
            // 
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Items.AddRange(new object[] { "Kopi", "Kakao" });
            cmbJenis.Location = new Point(72, 179);
            cmbJenis.Margin = new Padding(5, 5, 5, 5);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(201, 40);
            cmbJenis.TabIndex = 4;
            cmbJenis.Text = "Jenis Tanaman";
            // 
            // btnTampilkanLaporan
            // 
            btnTampilkanLaporan.Location = new Point(177, 251);
            btnTampilkanLaporan.Margin = new Padding(5, 5, 5, 5);
            btnTampilkanLaporan.Name = "btnTampilkanLaporan";
            btnTampilkanLaporan.Size = new Size(292, 46);
            btnTampilkanLaporan.TabIndex = 5;
            btnTampilkanLaporan.Text = "TAMPILKAN  LAPORAN";
            btnTampilkanLaporan.UseVisualStyleBackColor = true;
            // 
            // btnPetugas
            // 
            btnPetugas.Location = new Point(556, 251);
            btnPetugas.Margin = new Padding(5, 5, 5, 5);
            btnPetugas.Name = "btnPetugas";
            btnPetugas.Size = new Size(262, 46);
            btnPetugas.TabIndex = 6;
            btnPetugas.Text = "CETAK LAPORAN";
            btnPetugas.UseVisualStyleBackColor = true;
            // 
            // dgvLaporan
            // 
            dgvLaporan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaporan.Location = new Point(72, 338);
            dgvLaporan.Margin = new Padding(5, 5, 5, 5);
            dgvLaporan.Name = "dgvLaporan";
            dgvLaporan.RowHeadersWidth = 51;
            dgvLaporan.Size = new Size(847, 349);
            dgvLaporan.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(411, 179);
            dateTimePicker1.Margin = new Padding(5, 5, 5, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(404, 39);
            dateTimePicker1.TabIndex = 9;
            // 
            // Laporan
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1027, 720);
            Controls.Add(dateTimePicker1);
            Controls.Add(dgvLaporan);
            Controls.Add(btnPetugas);
            Controls.Add(btnTampilkanLaporan);
            Controls.Add(cmbJenis);
            Controls.Add(txtPetugas);
            DoubleBuffered = true;
            Margin = new Padding(5, 5, 5, 5);
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
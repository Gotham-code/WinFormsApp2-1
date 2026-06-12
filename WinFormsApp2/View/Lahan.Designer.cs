namespace WinFormsApp2.View
{
    partial class Lahan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lahan));
            txtLokasi = new TextBox();
            txtNamaLahan = new TextBox();
            txtLuas = new TextBox();
            txtIdlahan = new TextBox();
            cmbJenis = new ComboBox();
            btnTambah = new Button();
            btnHapus = new Button();
            btnEdit = new Button();
            btnSimpan = new Button();
            dgvLahan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLahan).BeginInit();
            SuspendLayout();
            // 
            // txtLokasi
            // 
            txtLokasi.Location = new Point(381, 67);
            txtLokasi.Name = "txtLokasi";
            txtLokasi.Size = new Size(125, 27);
            txtLokasi.TabIndex = 0;
            txtLokasi.Text = "Lokasi";
            // 
            // txtNamaLahan
            // 
            txtNamaLahan.Location = new Point(63, 119);
            txtNamaLahan.Name = "txtNamaLahan";
            txtNamaLahan.Size = new Size(125, 27);
            txtNamaLahan.TabIndex = 2;
            txtNamaLahan.Text = "Nama Lahan ";
            // 
            // txtLuas
            // 
            txtLuas.Location = new Point(218, 119);
            txtLuas.Name = "txtLuas";
            txtLuas.Size = new Size(125, 27);
            txtLuas.TabIndex = 3;
            txtLuas.Text = "Luas";
            // 
            // txtIdlahan
            // 
            txtIdlahan.Location = new Point(63, 67);
            txtIdlahan.Name = "txtIdlahan";
            txtIdlahan.Size = new Size(125, 27);
            txtIdlahan.TabIndex = 4;
            txtIdlahan.Text = "idlahan";
            // 
            // cmbJenis
            // 
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Location = new Point(218, 67);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(125, 28);
            cmbJenis.TabIndex = 5;
            cmbJenis.Text = "Jenis";
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(63, 183);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 29);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "TAMBAH";
            btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(464, 183);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 7;
            btnHapus.Text = "HAPUS";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(336, 183);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(207, 183);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 9;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // dgvLahan
            // 
            dgvLahan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLahan.Location = new Point(63, 231);
            dgvLahan.Name = "dgvLahan";
            dgvLahan.RowHeadersWidth = 51;
            dgvLahan.Size = new Size(495, 188);
            dgvLahan.TabIndex = 10;
            // 
            // Lahan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(626, 450);
            Controls.Add(dgvLahan);
            Controls.Add(btnSimpan);
            Controls.Add(btnEdit);
            Controls.Add(btnHapus);
            Controls.Add(btnTambah);
            Controls.Add(cmbJenis);
            Controls.Add(txtIdlahan);
            Controls.Add(txtLuas);
            Controls.Add(txtNamaLahan);
            Controls.Add(txtLokasi);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Lahan";
            Text = "Form1";
            Load += Lahan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLahan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLokasi;
        private TextBox txtNamaLahan;
        private TextBox txtLuas;
        private TextBox txtIdlahan;
        private ComboBox cmbJenis;
        private Button btnTambah;
        private Button btnHapus;
        private Button btnEdit;
        private Button btnSimpan;
        private DataGridView dgvLahan;
    }
}
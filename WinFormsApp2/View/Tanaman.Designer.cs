namespace WinFormsApp2.View
{
    partial class Tanaman
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tanaman));
            dgvTanaman = new DataGridView();
            txtIdTanaman = new TextBox();
            txtNamaTanaman = new TextBox();
            txtVarietas = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cboKomoditas = new ComboBox();
            btnSimpan = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            btnReset = new Button();
            dtpTanggalTanam = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvTanaman).BeginInit();
            SuspendLayout();
            // 
            // dgvTanaman
            // 
            dgvTanaman.AllowUserToAddRows = false;
            dgvTanaman.AllowUserToDeleteRows = false;
            dgvTanaman.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTanaman.BackgroundColor = Color.White;
            dgvTanaman.BorderStyle = BorderStyle.None;
            dgvTanaman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTanaman.Location = new Point(64, 217);
            dgvTanaman.MultiSelect = false;
            dgvTanaman.Name = "dgvTanaman";
            dgvTanaman.ReadOnly = true;
            dgvTanaman.RowHeadersVisible = false;
            dgvTanaman.RowHeadersWidth = 51;
            dgvTanaman.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTanaman.Size = new Size(513, 208);
            dgvTanaman.TabIndex = 6;
            dgvTanaman.CellClick += dgvTanaman_CellClick;
            // 
            // txtIdTanaman
            // 
            txtIdTanaman.Location = new Point(85, 66);
            txtIdTanaman.Name = "txtIdTanaman";
            txtIdTanaman.PlaceholderText = "ID Tanaman";
            txtIdTanaman.Size = new Size(125, 27);
            txtIdTanaman.TabIndex = 7;
            txtIdTanaman.Tag = "txtIdTanaman";
            txtIdTanaman.TextChanged += textBox1_TextChanged;
            // 
            // txtNamaTanaman
            // 
            txtNamaTanaman.Location = new Point(85, 104);
            txtNamaTanaman.Name = "txtNamaTanaman";
            txtNamaTanaman.PlaceholderText = "Masukkan Nama Tanaman";
            txtNamaTanaman.Size = new Size(125, 27);
            txtNamaTanaman.TabIndex = 8;
            txtNamaTanaman.Tag = "txtNamaTanaman";
            txtNamaTanaman.TextChanged += textBox2_TextChanged;
            // 
            // txtVarietas
            // 
            txtVarietas.CharacterCasing = CharacterCasing.Upper;
            txtVarietas.Location = new Point(250, 104);
            txtVarietas.Name = "txtVarietas";
            txtVarietas.PlaceholderText = "Masukkan Varietas";
            txtVarietas.Size = new Size(125, 27);
            txtVarietas.TabIndex = 11;
            txtVarietas.TextChanged += txtVarietas_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // cboKomoditas
            // 
            cboKomoditas.FormattingEnabled = true;
            cboKomoditas.Items.AddRange(new object[] { "Kopi", "Kakao" });
            cboKomoditas.Location = new Point(250, 66);
            cboKomoditas.Name = "cboKomoditas";
            cboKomoditas.Size = new Size(125, 28);
            cboKomoditas.TabIndex = 13;
            cboKomoditas.Text = "Jenis";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(164, 156);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 15;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += button1_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(264, 156);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += button2_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(364, 156);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 17;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += button4_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(464, 156);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 18;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += button5_Click;
            // 
            // dtpTanggalTanam
            // 
            dtpTanggalTanam.Location = new Point(421, 67);
            dtpTanggalTanam.Name = "dtpTanggalTanam";
            dtpTanggalTanam.Size = new Size(250, 27);
            dtpTanggalTanam.TabIndex = 19;
            // 
            // Tanaman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(831, 450);
            Controls.Add(dtpTanggalTanam);
            Controls.Add(btnReset);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnSimpan);
            Controls.Add(cboKomoditas);
            Controls.Add(txtVarietas);
            Controls.Add(txtNamaTanaman);
            Controls.Add(txtIdTanaman);
            Controls.Add(dgvTanaman);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tanaman";
            Text = "Tanaman";
            Load += Tanaman_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTanaman).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private void txtVarietas_TextChanged(object sender, EventArgs e)
        {
            // Biarkan kosong seperti ini untuk memancing agar Designer bisa terbuka lagi
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Button btnSimpan;
        private Button btnEdit;
        private Button btnHapus;
        private Button btnReset;
        public TextBox txtVarietas;
        public DataGridView dgvTanaman;
        public TextBox txtNamaTanaman;
        public TextBox txtIdTanaman;
        public ComboBox cboKomoditas;
        public DateTimePicker dtpTanggalTanam;

    }
}
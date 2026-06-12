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
            txtId = new TextBox();
            txtNama = new TextBox();
            txtTgl = new TextBox();
            txtVarietas = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtJenis = new ComboBox();
            btnTambah = new Button();
            btnSimpan = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTanaman).BeginInit();
            SuspendLayout();
            // 
            // dgvTanaman
            // 
            dgvTanaman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTanaman.Location = new Point(64, 217);
            dgvTanaman.Name = "dgvTanaman";
            dgvTanaman.RowHeadersWidth = 51;
            dgvTanaman.Size = new Size(513, 208);
            dgvTanaman.TabIndex = 6;
            // 
            // txtId
            // 
            txtId.Location = new Point(85, 66);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 7;
            txtId.Tag = "Nama Tanaman";
            txtId.Text = "IDTanaman";
            txtId.TextChanged += textBox1_TextChanged;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(85, 104);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(125, 27);
            txtNama.TabIndex = 8;
            txtNama.Text = "NamaTanaman";
            txtNama.TextChanged += textBox2_TextChanged;
            // 
            // txtTgl
            // 
            txtTgl.Location = new Point(432, 66);
            txtTgl.Name = "txtTgl";
            txtTgl.Size = new Size(125, 27);
            txtTgl.TabIndex = 10;
            txtTgl.Text = "TglTanam";
            // 
            // txtVarietas
            // 
            txtVarietas.Location = new Point(250, 104);
            txtVarietas.Name = "txtVarietas";
            txtVarietas.Size = new Size(125, 27);
            txtVarietas.TabIndex = 11;
            txtVarietas.Text = "Varietas";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtJenis
            // 
            txtJenis.FormattingEnabled = true;
            txtJenis.Location = new Point(250, 66);
            txtJenis.Name = "txtJenis";
            txtJenis.Size = new Size(125, 28);
            txtJenis.TabIndex = 13;
            txtJenis.Text = "Jenis";
            // 
            // btnTambah
            // 
            btnTambah.BackgroundImageLayout = ImageLayout.None;
            btnTambah.Location = new Point(64, 156);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 29);
            btnTambah.TabIndex = 14;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += button7_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(164, 156);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 15;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(264, 156);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(364, 156);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 17;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(464, 156);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 18;
            btnReset.Text = "Edit";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // Tanaman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(831, 450);
            Controls.Add(btnReset);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnSimpan);
            Controls.Add(btnTambah);
            Controls.Add(txtJenis);
            Controls.Add(txtVarietas);
            Controls.Add(txtTgl);
            Controls.Add(txtNama);
            Controls.Add(txtId);
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

        #endregion
        private DataGridView dgvTanaman;
        private TextBox txtId;
        private TextBox txtNama;
        private TextBox txtTgl;
        private TextBox txtVarietas;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox txtJenis;
        private Button btnTambah;
        private Button btnSimpan;
        private Button btnEdit;
        private Button btnHapus;
        private Button btnReset;
    }
}
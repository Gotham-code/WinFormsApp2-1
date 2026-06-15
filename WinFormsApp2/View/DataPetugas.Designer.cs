namespace WinFormsApp2.View
{
    partial class DataPetugas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataPetugas));
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtNama = new TextBox();
            btnSimpan = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            dgvDataPetugas = new DataGridView();
            txtIdPetugas = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDataPetugas).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(343, 174);
            txtPassword.Margin = new Padding(5);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Masukkan Password";
            txtPassword.Size = new Size(201, 39);
            txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(343, 111);
            txtUsername.Margin = new Padding(5);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Masukkan Username";
            txtUsername.Size = new Size(201, 39);
            txtUsername.TabIndex = 2;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(113, 174);
            txtNama.Margin = new Padding(5);
            txtNama.Name = "txtNama";
            txtNama.PlaceholderText = "Masukkan Nama Lengkap";
            txtNama.Size = new Size(201, 39);
            txtNama.TabIndex = 3;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(343, 248);
            btnSimpan.Margin = new Padding(5);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(153, 46);
            btnSimpan.TabIndex = 5;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(572, 248);
            btnEdit.Margin = new Padding(5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(153, 46);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(793, 248);
            btnHapus.Margin = new Padding(5);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(153, 46);
            btnHapus.TabIndex = 7;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // dgvDataPetugas
            // 
            dgvDataPetugas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataPetugas.Location = new Point(84, 346);
            dgvDataPetugas.Margin = new Padding(5);
            dgvDataPetugas.Name = "dgvDataPetugas";
            dgvDataPetugas.RowHeadersWidth = 51;
            dgvDataPetugas.Size = new Size(897, 355);
            dgvDataPetugas.TabIndex = 8;
            dgvDataPetugas.CellClick += DataGridPetugas_CellClick;
            // 
            // txtIdPetugas
            // 
            txtIdPetugas.Location = new Point(113, 111);
            txtIdPetugas.Name = "txtIdPetugas";
            txtIdPetugas.PlaceholderText = "ID petugas";
            txtIdPetugas.Size = new Size(200, 39);
            txtIdPetugas.TabIndex = 9;
            // 
            // DataPetugas
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1300, 720);
            Controls.Add(txtIdPetugas);
            Controls.Add(dgvDataPetugas);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnSimpan);
            Controls.Add(txtNama);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "DataPetugas";
            Text = "DataPetugas";
            Load += DataPetugas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDataPetugas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox txtPassword;
        public TextBox txtUsername;
        public TextBox txtNama;
        public Button btnSimpan;
        public Button btnEdit;
        public Button btnHapus;
        public DataGridView dgvDataPetugas;
        public TextBox txtIdPetugas;
    }
}
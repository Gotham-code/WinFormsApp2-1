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
            txtRole = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtNama = new TextBox();
            btnTambah = new Button();
            btnSimpan = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            dgvDataPetugas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDataPetugas).BeginInit();
            SuspendLayout();
            // 
            // txtRole
            // 
            txtRole.Location = new Point(327, 111);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(125, 27);
            txtRole.TabIndex = 0;
            txtRole.Text = "Role";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(326, 78);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "Passsword";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(65, 111);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "Username";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(64, 78);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(125, 27);
            txtNama.TabIndex = 3;
            txtNama.Text = "Nama";
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(79, 155);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 29);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(211, 155);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 5;
            btnSimpan.Text = "SImpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(352, 155);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(488, 155);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 7;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // dgvDataPetugas
            // 
            dgvDataPetugas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataPetugas.Location = new Point(52, 216);
            dgvDataPetugas.Name = "dgvDataPetugas";
            dgvDataPetugas.RowHeadersWidth = 51;
            dgvDataPetugas.Size = new Size(552, 222);
            dgvDataPetugas.TabIndex = 8;
            // 
            // DataPetugas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDataPetugas);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnSimpan);
            Controls.Add(btnTambah);
            Controls.Add(txtNama);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtRole);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "DataPetugas";
            Text = "DataPetugascs";
            Load += DataPetugascs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDataPetugas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRole;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtNama;
        private Button btnTambah;
        private Button btnSimpan;
        private Button btnEdit;
        private Button btnHapus;
        private DataGridView dgvDataPetugas;
    }
}
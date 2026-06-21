using System;
using System.Windows.Forms;
using WinFormsApp2.UserController; 

namespace WinFormsApp2.View
{
    public partial class Tanaman : Form
    {
        private TanamanController controller;

        public Tanaman()
        {
            InitializeComponent();
            controller = new TanamanController(this);
        }

        private void Tanaman_Load(object sender, EventArgs e)
        {
            controller.TampilData();
            ResetForm();
        }

        // Tombol SIMPAN (Sesuaikan button dengan double click tombol SIMPAN di UI Anda)
        private void button1_Click(object sender, EventArgs e)
        {
            controller.Simpan();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            controller.Ubah();
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            controller.Hapus();
        }

       
        private void button5_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        public void ResetForm()
        {
            if (txtIdTanaman != null) 
            {
                txtIdTanaman.Text = "";
                txtIdTanaman.Tag = null;
            }
            if (txtNamaTanaman != null) txtNamaTanaman.Clear();
            if (txtVarietas != null) txtVarietas.Clear();

            if (cboKomoditas != null && cboKomoditas.Items.Count > 0)
            {
                cboKomoditas.SelectedIndex = 0;
            }

            btnSimpan.Enabled = true;
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
        }

        public void dgvTanaman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTanaman.Rows[e.RowIndex].Cells["ID"].Value != null)
            {
                DataGridViewRow row = dgvTanaman.Rows[e.RowIndex];

               
                txtIdTanaman.Tag = row.Cells["ID"].Value?.ToString() ?? "0";
                txtIdTanaman.Text = $"ID: {row.Cells["ID"].Value}";
                txtNamaTanaman.Text = row.Cells["Nama Tanaman"].Value?.ToString() ?? "";
                txtVarietas.Text = row.Cells["Varietas"].Value?.ToString() ?? "";
                cboKomoditas.SelectedItem = row.Cells["Jenis"].Value?.ToString();

                btnSimpan.Enabled = false;
                btnEdit.Enabled = true;
                btnHapus.Enabled = true;
            }
        }

       
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }

    }
}
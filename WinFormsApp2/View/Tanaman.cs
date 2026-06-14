using System;
using System.Windows.Forms;
using WinFormsApp2.UserController; // Hubungkan ke nama folder controller Anda

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

        // Tombol EDIT/UBAH (Sesuaikan button dengan double click tombol EDIT di UI Anda)
        private void button2_Click(object sender, EventArgs e)
        {
            controller.Ubah();
        }

        // Tombol HAPUS (Sesuaikan button dengan double click tombol HAPUS di UI Anda)
        private void button4_Click(object sender, EventArgs e)
        {
            controller.Hapus();
        }

        // Tombol RESET (Sesuaikan button dengan double click tombol RESET di UI Anda)
        private void button5_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        public void ResetForm()
        {
            if (txtIdTanaman != null) txtIdTanaman.Clear();
            if (txtNamaTanaman != null) txtNamaTanaman.Clear();
            if (txtVarietas != null) txtVarietas.Clear();

            if (cboKomoditas != null && cboKomoditas.Items.Count > 0)
            {
                cboKomoditas.SelectedIndex = 0;
            }

            if (dtpTanggalTanam != null)
            {
                dtpTanggalTanam.Value = DateTime.Now;
            }
        }

        public void dgvTanaman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTanaman.Rows[e.RowIndex].Cells["ID"].Value != null)
            {
                DataGridViewRow row = dgvTanaman.Rows[e.RowIndex];

                txtIdTanaman.Text = row.Cells["ID"].Value?.ToString() ?? "";
                txtNamaTanaman.Text = row.Cells["Nama Tanaman"].Value?.ToString() ?? "";
                txtVarietas.Text = row.Cells["Varietas"].Value?.ToString() ?? "";
                cboKomoditas.SelectedItem = row.Cells["Jenis"].Value?.ToString();

                if (row.Cells["Tgl Tanam"].Value != null)
                {
                    dtpTanggalTanam.Value = Convert.ToDateTime(row.Cells["Tgl Tanam"].Value);
                }

                btnSimpan.Enabled = false;
                btnEdit.Enabled = true;
                btnHapus.Enabled = true;
            }
        }

        // Metode penampung sisa agar tidak memicu error designer akibat text_changed lama
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }

    }
}
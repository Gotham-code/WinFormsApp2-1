using System;
using System.Windows.Forms;
using MonitoringKopiKakao.Model;
using WinFormsApp2.View; // Sesuaikan dengan namespace folder View Anda

namespace MonitoringKopiKakao.Controller
{
    public class LahanController
    {
        private Lahan view;
        private LahanModel model;

        // Konstruktor untuk menghubungkan controller dengan form view aktif
        public LahanController(Lahan view)
        {
            this.view = view;
            this.model = new LahanModel();
        }

        public void TampilData()
        {
            try
            {
                view.dgvLahan.DataSource = model.GetAllLahan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data lahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Simpan()
        {
            try
            {
                // Validasi input kosong
                if (string.IsNullOrEmpty(view.txtLokasi.Text) || string.IsNullOrEmpty(view.txtLuas.Text))
                {
                    MessageBox.Show("Semua data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                model.Lokasi = view.txtLokasi.Text;
                model.LuasLahan = Convert.ToDouble(view.txtLuas.Text);
                model.JenisTanah = view.cboJenisTanah.SelectedItem.ToString();

                model.InsertLahan();
                MessageBox.Show("Data Lahan berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                view.ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Ubah()
        {
            try
            {
                model.IdLahan = Convert.ToInt32(view.txtIdLahan.Text);
                model.Lokasi = view.txtLokasi.Text;
                model.LuasLahan = Convert.ToDouble(view.txtLuas.Text);
                model.JenisTanah = view.cboJenisTanah.SelectedItem.ToString();

                model.UpdateLahan();
                MessageBox.Show("Data Lahan berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                view.ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Hapus()
        {
            try
            {
                int id = Convert.ToInt32(view.txtIdLahan.Text);
                var konfirmasi = MessageBox.Show("Hapus lahan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (konfirmasi == DialogResult.Yes)
                {
                    model.DeleteLahan(id);
                    MessageBox.Show("Data Lahan berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TampilData();
                    view.ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
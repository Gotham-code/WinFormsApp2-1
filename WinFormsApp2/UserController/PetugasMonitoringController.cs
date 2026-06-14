using System;
using System.Windows.Forms;
using MonitoringKopiKakao.Model;
using WinFormsApp2.View;

namespace MonitoringKopiKakao.Controller
{
    public class PetugasController
    {
        private DataPetugas view;
        private PetugasModel model;

        public PetugasController(DataPetugas view)
        {
            this.view = view;
            this.model = new PetugasModel();
        }

        public void TampilData()
        {
            try { view.DataGridPetugas.DataSource = model.GetAllPetugas(); }
            catch (Exception ex) { MessageBox.Show("Gagal memuat petugas: " + ex.Message); }
        }

        public void Simpan()
        {
            try
            {
                model.Username = view.TxtUsername.Text;
                model.Password = view.TxtPassword.Text;
                model.NamaPetugas = view.TxtNamaPetugas.Text;

                model.InsertPetugas();
                MessageBox.Show("Data Petugas berhasil ditambahkan!");
                TampilData();
                view.ResetForm();
            }
            catch (Exception ex) { MessageBox.Show("Gagal menambahkan petugas: " + ex.Message); }
        }

        public void Ubah()
        {
            try
            {
                model.Username = view.TxtUsername.Text;
                model.Password = view.TxtPassword.Text;
                model.NamaPetugas = view.TxtNamaPetugas.Text;

                model.UpdatePetugas();
                MessageBox.Show("Data Petugas berhasil diperbarui!");
                TampilData();
                view.ResetForm();
            }
            catch (Exception ex) { MessageBox.Show("Gagal memperbarui petugas: " + ex.Message); }
        }

        public void Hapus()
        {
            try
            {
                int nama = Convert.ToInt32(view.TxtNamaPetugas.Text);
                if (MessageBox.Show("Hapus akun petugas terpilih?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    model.DeletePetugas(nama);
                    MessageBox.Show("Data Petugas berhasil dihapus!");
                    TampilData();
                    view.ResetForm();
                }
            }
            catch (Exception ex) { MessageBox.Show("Gagal menghapus petugas: " + ex.Message); }
        }
    }
}
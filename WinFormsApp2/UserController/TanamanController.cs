using System;
using System.Windows.Forms;
using WinFormsApp2.Models; // Hubungkan ke namespace Models baru
using WinFormsApp2.View;   // Hubungkan ke namespace View baru

namespace WinFormsApp2.UserController
{
    public class TanamanController
    {
        private Tanaman view;
        private TanamanModel model;

        public TanamanController(Tanaman view)
        {
            this.view = view;
            this.model = new TanamanModel();
        }

        public void TampilData()
        {
            try
            {
                if (view.dgvTanaman != null)
                {
                    view.dgvTanaman.DataSource = model.GetAllTanaman();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Simpan()
        {
            try
            {
                if (view.txtNamaTanaman == null || view.txtVarietas == null ||
                    view.cboKomoditas == null || view.dtpTanggalTanam == null)
                {
                    MessageBox.Show("Komponen UI gagal dimuat!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(view.txtNamaTanaman.Text) ||
                    string.IsNullOrWhiteSpace(view.txtVarietas.Text) ||
                    view.cboKomoditas.SelectedItem == null)
                {
                    MessageBox.Show("Kolom input wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                model.NamaTanaman = view.txtNamaTanaman.Text.Trim();
                model.Varietas = view.txtVarietas.Text.Trim();
                model.TanggalTanam = view.dtpTanggalTanam.Value;
                model.JenisKomoditas = view.cboKomoditas.SelectedItem?.ToString() ?? "";

                // Mengisi umur default/formal karena di UI halaman 7 tidak ada input umur
                model.UmurTanaman = 0;

                model.InsertTanaman();
                MessageBox.Show("Data Tanaman berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                if (view.txtIdTanaman == null || view.txtNamaTanaman == null ||
                    view.txtVarietas == null || view.cboKomoditas == null || view.dtpTanggalTanam == null) return;

                if (string.IsNullOrWhiteSpace(view.txtIdTanaman.Text))
                {
                    MessageBox.Show("Pilih data tanaman terlebih dahulu dari tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                model.IdTanaman = Convert.ToInt32(view.txtIdTanaman.Text);
                model.NamaTanaman = view.txtNamaTanaman.Text.Trim();
                model.Varietas = view.txtVarietas.Text.Trim();
                model.TanggalTanam = view.dtpTanggalTanam.Value;
                model.JenisKomoditas = view.cboKomoditas.SelectedItem?.ToString() ?? "";
                model.UmurTanaman = 0;

                model.UpdateTanaman();
                MessageBox.Show("Data Tanaman berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                if (view.txtIdTanaman == null) return;

                if (string.IsNullOrWhiteSpace(view.txtIdTanaman.Text))
                {
                    MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(view.txtIdTanaman.Text);
                var konfirmasi = MessageBox.Show("Apakah Anda yakin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (konfirmasi == DialogResult.Yes)
                {
                    model.DeleteTanaman(id);
                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
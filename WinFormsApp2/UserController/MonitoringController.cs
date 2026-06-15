using System;
using System.Windows.Forms;
using System.Data;
using WinFormsApp2.Models;
using WinFormsApp2.View;

namespace WinFormsApp2.UserController
{
    public class MonitoringController
    {
        private InputMonitoring viewInput;
        private RiwayatMonitoring viewRiwayat;
        private MonitoringModel model;

        public MonitoringController(InputMonitoring view)
        {
            this.viewInput = view;
            this.model = new MonitoringModel();
        }

        public MonitoringController(RiwayatMonitoring view)
        {
            this.viewRiwayat = view;
            this.model = new MonitoringModel();
        }

        public void TampilDataInput()
        {
            try
            {
                viewInput.dataGridView1.DataSource = model.GetAllMonitoring();
                // reset selection and buttons
                viewInput.btnEdit.Enabled = false;
                viewInput.btnSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data monitoring: " + ex.Message);
            }
        }

        public void LoadDropdowns()
        {
            try
            {
                var dtTanaman = model.GetTanamanList();
                if (dtTanaman != null && viewInput.comboBoxTanaman != null)
                {
                    if (dtTanaman.Rows.Count > 0)
                    {
                        viewInput.comboBoxTanaman.DisplayMember = "nama_tanaman";
                        viewInput.comboBoxTanaman.ValueMember = "id_tanaman";
                        viewInput.comboBoxTanaman.DataSource = dtTanaman;
                        viewInput.comboBoxTanaman.DropDownStyle = ComboBoxStyle.DropDownList;
                        if (viewInput.comboBoxTanaman.Items.Count > 0)
                            viewInput.comboBoxTanaman.SelectedIndex = 0;
                    }
                }

                var dtPetugas = model.GetPetugasList();
                if (dtPetugas != null && viewInput.comboBoxPetugas != null)
                {
                    if (dtPetugas.Rows.Count > 0)
                    {
                        viewInput.comboBoxPetugas.DisplayMember = "nama";
                        viewInput.comboBoxPetugas.ValueMember = "id_user";
                        viewInput.comboBoxPetugas.DataSource = dtPetugas;
                        viewInput.comboBoxPetugas.DropDownStyle = ComboBoxStyle.DropDownList;
                        if (viewInput.comboBoxPetugas.Items.Count > 0)
                            viewInput.comboBoxPetugas.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat dropdown: " + ex.Message);
            }
        }

        public void TampilDataRiwayat()
        {
            try
            {
                viewRiwayat.dataGridView1.DataSource = model.GetAllMonitoring();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat riwayat monitoring: " + ex.Message);
            }
        }

        public void SimpanFromInput()
        {
            try
            {
                // Mapping yang sesuai dengan kontrol di form InputMonitoring
                model.Tanggal = viewInput.dateTimePicker1?.Value ?? DateTime.Now;

                // Ambil id tanaman dari comboBoxTanaman dengan beberapa pendekatan aman
                model.IdTanaman = 0;
                try
                {
                    if (viewInput.comboBoxTanaman != null)
                    {
                        var sel = viewInput.comboBoxTanaman.SelectedValue;
                        if (sel != null && sel != DBNull.Value)
                        {
                            model.IdTanaman = Convert.ToInt32(sel);
                        }
                        else if (viewInput.comboBoxTanaman.SelectedItem is DataRowView drv)
                        {
                            model.IdTanaman = Convert.ToInt32(drv["id_tanaman"]);
                        }
                        else if (!string.IsNullOrWhiteSpace(viewInput.comboBoxTanaman.Text))
                        {
                            // fallback: cari id dari nama pada daftar tanaman
                            var dtLookup = model.GetTanamanList();
                            if (dtLookup != null)
                            {
                                foreach (DataRow r in dtLookup.Rows)
                                {
                                    if (string.Equals(r["nama_tanaman"]?.ToString(), viewInput.comboBoxTanaman.Text, StringComparison.OrdinalIgnoreCase))
                                    {
                                        model.IdTanaman = Convert.ToInt32(r["id_tanaman"]);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                catch
                {
                    model.IdTanaman = 0;
                }

                // Kondisi tanaman diambil dari comboBoxPetugas (labelnya 'Kondisi' di designer)
                model.Kondisi = viewInput.comboBoxPetugas?.Text ?? string.Empty;

                // Gunakan comboBox2 sebagai catatan/cuaca
                model.Cuaca = viewInput.comboBox2?.Text ?? string.Empty;

                // Id user: gunakan Session jika ada, fallback ke comboBoxPetugas.SelectedValue jika itu berisi petugas
                if (WinFormsApp2.Session.IdUser > 0)
                    model.IdUser = WinFormsApp2.Session.IdUser;
                else if (viewInput.comboBoxPetugas != null && viewInput.comboBoxPetugas.SelectedValue != null && int.TryParse(viewInput.comboBoxPetugas.SelectedValue.ToString(), out var idu))
                    model.IdUser = idu;
                else
                    model.IdUser = 0;

                // Validasi: pastikan id_tanaman dan id_user valid untuk mencegah pelanggaran foreign key
                if (model.IdTanaman <= 0)
                {
                    MessageBox.Show("Pilih tanaman yang valid sebelum menyimpan.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (model.IdUser <= 0)
                {
                    MessageBox.Show("Id petugas tidak tersedia. Pastikan Anda sudah login atau pilih petugas yang valid.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                model.InsertMonitoring();
                MessageBox.Show("Data monitoring berhasil disimpan!");
                TampilDataInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan monitoring: " + ex.Message);
            }
        }

        public void HapusFromRiwayat()
        {
            try
            {
                if (viewRiwayat.dataGridView1.CurrentRow == null) return;
                var val = viewRiwayat.dataGridView1.CurrentRow.Cells["ID"].Value;
                if (val == null) return;
                int id = Convert.ToInt32(val);
                if (MessageBox.Show("Hapus monitoring terpilih?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    model.DeleteMonitoring(id);
                    MessageBox.Show("Data monitoring berhasil dihapus!");
                    TampilDataRiwayat();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus monitoring: " + ex.Message);
            }
        }
    }
}

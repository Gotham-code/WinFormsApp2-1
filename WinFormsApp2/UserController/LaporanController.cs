using System;
using System.Data;
using System.Windows.Forms;
using WinFormsApp2.Models;
using WinFormsApp2.View;

namespace WinFormsApp2.UserController
{
    public class LaporanController
    {
        private Laporan view;
        private MonitoringModel model;

        public LaporanController(Laporan view)
        {
            this.view = view;
            this.model = new MonitoringModel();
        }

        public void TampilData()
        {
            try
            {
                view.dgvLaporan.DataSource = model.GetAllMonitoring();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat laporan: " + ex.Message);
            }
        }

        public void TampilFilter(string namaPetugas, string jenisTanaman, DateTime? tanggal)
        {
            try
            {
                var dt = model.GetAllMonitoring();
                if (dt == null) dt = new DataTable();

                // Apply basic filtering in-memory
                DataView dv = new DataView(dt);
                string filter = "";
                if (!string.IsNullOrWhiteSpace(namaPetugas))
                {
                    filter += $"PETUGAS LIKE '%" + namaPetugas.Replace("'", "''") + "%'";
                }
                if (!string.IsNullOrWhiteSpace(jenisTanaman))
                {
                    if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                    filter += $"TANAMAN = '" + jenisTanaman.Replace("'", "''") + "'";
                }
                if (tanggal.HasValue)
                {
                    if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                    // compare date part only
                    filter += $"CONVERT(varchar, TANGGAL, 23) = '" + tanggal.Value.ToString("yyyy-MM-dd") + "'";
                }

                if (!string.IsNullOrEmpty(filter))
                    dv.RowFilter = filter;

                view.dgvLaporan.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memfilter laporan: " + ex.Message);
            }
        }
    }
}

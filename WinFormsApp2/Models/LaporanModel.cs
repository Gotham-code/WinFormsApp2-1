using MonitoringKopiKakao;
using System;
using System.Data;

namespace WinFormsApp2.Models
{
    public class LaporanModel
    {
        private DatabaseConfig db = new DatabaseConfig();

        public DataTable GetLaporan(DateTime tglAwal, DateTime tglAkhir, string jenis = "", string petugas = "", string cari = "")
        {
            // Query untuk menggabungkan data monitoring, tanaman, dan petugas
            string query = $@"
                SELECT 
                    m.id_monitoring AS ""ID"",
                    m.tanggal AS ""TANGGAL"",
                    t.nama_tanaman AS ""TANAMAN"",
                    m.kondisi AS ""KONDISI"",
                    m.hama AS ""HAMA"",
                    m.cuaca AS ""CUACA"",
                    p.nama AS ""PETUGAS""
                FROM monitoring m
                JOIN tanaman t ON m.id_tanaman = t.id_tanaman
                JOIN petugas_monitoring p ON m.id_user = p.id_user
                WHERE m.tanggal BETWEEN '{tglAwal:yyyy-MM-dd}' AND '{tglAkhir:yyyy-MM-dd}'";

            if (!string.IsNullOrEmpty(jenis) && jenis != "Semua")
                query += $" AND t.jenis_komoditas = '{jenis}'";

            if (!string.IsNullOrEmpty(petugas) && petugas != "Semua")
                query += $" AND p.nama = '{petugas}'";

            if (!string.IsNullOrEmpty(cari))
                query += $" AND (t.nama_tanaman ILIKE '%{cari}%' OR p.nama ILIKE '%{cari}%')";

            query += " ORDER BY m.tanggal DESC";
            
            return db.ExecuteQuery(query);
        }
    }
}

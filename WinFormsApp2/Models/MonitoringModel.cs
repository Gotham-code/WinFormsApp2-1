using MonitoringKopiKakao;
using Npgsql;
using System;
using System.Data;

namespace WinFormsApp2.Models
{
    public class MonitoringModel
    {
        public int IdMonitoring { get; set; }
        public DateTime Tanggal { get; set; }
        public int IdTanaman { get; set; }
        public string Kondisi { get; set; } = string.Empty;
        public string Hama { get; set; } = string.Empty;
        public string Cuaca { get; set; } = string.Empty;
        public int IdUser { get; set; }

        private DatabaseConfig db = new DatabaseConfig();

        public DataTable GetAllMonitoring()
        {
            // Sesuaikan dengan struktur tabel monitoring yang tersedia: tinggi_tanaman, kondisi_tanaman, catatan
            string query = "SELECT m.id_monitoring AS \"ID\", m.tanggal AS \"TANGGAL\", t.nama_tanaman AS \"TANAMAN\", m.tinggi_tanaman AS \"TINGGI\", m.kondisi_tanaman AS \"KONDISI\", m.catatan AS \"CATATAN\", p.nama AS \"PETUGAS\" FROM monitoring m JOIN tanaman t ON m.id_tanaman = t.id_tanaman LEFT JOIN petugas_monitoring p ON m.id_user = p.id_user ORDER BY m.tanggal DESC";
            return db.ExecuteQuery(query);
        }

        public void InsertMonitoring()
        {
            string query = "INSERT INTO monitoring (tanggal, id_tanaman, tinggi_tanaman, kondisi_tanaman, catatan, id_user) VALUES (@tanggal, @id_tanaman, @tinggi, @kondisi, @catatan, @id_user)";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@tanggal", Tanggal);
                cmd.Parameters.AddWithValue("@id_tanaman", IdTanaman);
                cmd.Parameters.AddWithValue("@tinggi", (object)0.0 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@kondisi", Kondisi ?? string.Empty);
                cmd.Parameters.AddWithValue("@catatan", (object)Cuaca ?? string.Empty);
                cmd.Parameters.AddWithValue("@id_user", IdUser);
                db.ExecuteNonQuery(cmd);
            }
        }

        public void UpdateMonitoring()
        {
            string query = "UPDATE monitoring SET tanggal = @tanggal, id_tanaman = @id_tanaman, tinggi_tanaman = @tinggi, kondisi_tanaman = @kondisi, catatan = @catatan, id_user = @id_user WHERE id_monitoring = @id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@id", IdMonitoring);
                cmd.Parameters.AddWithValue("@tanggal", Tanggal);
                cmd.Parameters.AddWithValue("@id_tanaman", IdTanaman);
                cmd.Parameters.AddWithValue("@tinggi", (object)0.0 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@kondisi", Kondisi ?? string.Empty);
                cmd.Parameters.AddWithValue("@catatan", (object)Cuaca ?? string.Empty);
                cmd.Parameters.AddWithValue("@id_user", IdUser);
                db.ExecuteNonQuery(cmd);
            }
        }

        public void DeleteMonitoring(int id)
        {
            string query = "DELETE FROM monitoring WHERE id_monitoring = @id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@id", id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public DataTable GetTanamanList()
        {
            string query = "SELECT id_tanaman, nama_tanaman FROM tanaman ORDER BY nama_tanaman";
            return db.ExecuteQuery(query);
        }

        public DataTable GetPetugasList()
        {
            string query = "SELECT id_user, nama FROM petugas_monitoring ORDER BY nama";
            return db.ExecuteQuery(query);
        }
    }
}

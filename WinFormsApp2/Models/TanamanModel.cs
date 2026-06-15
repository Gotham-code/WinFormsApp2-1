using MonitoringKopiKakao;
using Npgsql;
using System;
using System.Data;
// Jika DatabaseConfig Anda berada di folder Data atau Helpers, 
// hilangkan tanda komentar (//) pada baris di bawah ini:
// using WinFormsApp2.Data; 

namespace WinFormsApp2.Models
{
    public class TanamanModel
    {
        public int IdTanaman { get; set; }
        public string NamaTanaman { get; set; } = string.Empty;
        public string Varietas { get; set; } = string.Empty;
        public int UmurTanaman { get; set; }
        public DateTime? TanggalTanam { get; set; }
        public string JenisKomoditas { get; set; } = string.Empty;

        // Pastikan class DatabaseConfig Anda sudah benar di dalam projek
        private DatabaseConfig db = new DatabaseConfig();

        public DataTable GetAllTanaman()
        {
            string query = "SELECT id_tanaman AS \"ID\", nama_tanaman AS \"Nama Tanaman\", jenis_komoditas AS \"Jenis\", varietas AS \"Varietas\" FROM tanaman ORDER BY id_tanaman DESC";
            return db.ExecuteQuery(query);
        }

        public void InsertTanaman()
        {
            string query = "INSERT INTO tanaman (id_tanaman, nama_tanaman, varietas, umur_tanaman, tanggal_tanam, jenis_komoditas) VALUES (@id, @nama, @varietas, @umur, @tanggal, @komoditas)";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@id", IdTanaman);
                cmd.Parameters.AddWithValue("@nama", NamaTanaman);
                cmd.Parameters.AddWithValue("@varietas", Varietas);
                cmd.Parameters.AddWithValue("@umur", UmurTanaman);
                cmd.Parameters.AddWithValue("@tanggal", (object)TanggalTanam ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@komoditas", JenisKomoditas);
                db.ExecuteNonQuery(cmd);
            }
        }

        public void UpdateTanaman()
        {
            string query = "UPDATE tanaman SET nama_tanaman = @nama, varietas = @varietas, umur_tanaman = @umur, tanggal_tanam = @tanggal, jenis_komoditas = @komoditas WHERE id_tanaman = @id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@id", IdTanaman);
                cmd.Parameters.AddWithValue("@nama", NamaTanaman);
                cmd.Parameters.AddWithValue("@varietas", Varietas);
                cmd.Parameters.AddWithValue("@umur", UmurTanaman);
                cmd.Parameters.AddWithValue("@tanggal", (object)TanggalTanam ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@komoditas", JenisKomoditas);
                db.ExecuteNonQuery(cmd);
            }
        }

        public void DeleteTanaman(int id)
        {
            string query = "DELETE FROM tanaman WHERE id_tanaman = @id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@id", id);
                db.ExecuteNonQuery(cmd);
            }
        }
    }
}
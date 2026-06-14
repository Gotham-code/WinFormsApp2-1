using System;
using System.Data;
using Npgsql;

namespace MonitoringKopiKakao.Model
{
    public class LahanModel
    {
        public int IdLahan { get; set; }
        public string Lokasi { get; set; }
        public double LuasLahan { get; set; }
        public string JenisTanah { get; set; }

        private DatabaseConfig db = new DatabaseConfig();

        // Ambil semua data lahan
        public DataTable GetAllLahan()
        {
            string query = "SELECT id_lahan AS \"ID\", lokasi AS \"Lokasi\", luas_lahan AS \"Luas (Ha)\", jenis_tanah AS \"Jenis Tanah\" FROM lahan ORDER BY id_lahan DESC";
            return db.ExecuteQuery(query);
        }

        // Simpan data
        public void InsertLahan()
        {
            string query = "INSERT INTO lahan (lokasi, luas_lahan, jenis_tanah) VALUES (@lokasi, @luas, @tanah)";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@lokasi", Lokasi);
                cmd.Parameters.AddWithValue("@luas", LuasLahan);
                cmd.Parameters.AddWithValue("@tanah", JenisTanah);
                db.ExecuteNonQuery(cmd);
            }
        }

        // Ubah data
        public void UpdateLahan()
        {
            string query = "UPDATE lahan SET lokasi = @lokasi, luas_lahan = @luas, jenis_tanah = @tanah WHERE id_lahan = @id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@id", IdLahan);
                cmd.Parameters.AddWithValue("@lokasi", Lokasi);
                cmd.Parameters.AddWithValue("@luas", LuasLahan);
                cmd.Parameters.AddWithValue("@tanah", JenisTanah);
                db.ExecuteNonQuery(cmd);
            }
        }

        // Hapus data
        public void DeleteLahan(int id)
        {
            string query = "DELETE FROM lahan WHERE id_lahan = @id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@id", id);
                db.ExecuteNonQuery(cmd);
            }
        }
    }
}
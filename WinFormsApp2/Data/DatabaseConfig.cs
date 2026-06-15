using System;
using System.Data;
using Npgsql;

namespace MonitoringKopiKakao
{
    public class DatabaseConfig
    {

        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=Salimbaikhati#33;Database=dbPuslitFinish";

        public DatabaseConfig()
        {
        }

        public NpgsqlConnection GetConnection()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }


        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                using (NpgsqlConnection conn = GetConnection())
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengeksekusi query: " + ex.Message);
            }
            return dt;
        }

        // Method untuk insert, update, delete
        public void ExecuteNonQuery(NpgsqlCommand cmd)
        {
            try
            {
                using (NpgsqlConnection conn = GetConnection())
                {
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menyimpan data: " + ex.Message);
            }
        }
    }
}
using System;
using System.Data;
using Npgsql;

namespace MonitoringKopiKakao
{
    public class DatabaseConfig
    {
    
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=admin123;Database=dbPuslitFinish";
        private NpgsqlConnection conn;

        public DatabaseConfig()
        {
            conn = new NpgsqlConnection(connString);
        }

        public NpgsqlConnection GetConnection()
        {
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
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, GetConnection()))
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
            finally
            {
                conn.Close();
            }
            return dt;
        }

        // Method untuk insert, update, delete
        public void ExecuteNonQuery(NpgsqlCommand cmd)
        {
            try
            {
                cmd.Connection = GetConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menyimpan data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
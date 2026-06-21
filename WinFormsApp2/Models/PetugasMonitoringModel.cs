using System;
using System.Data;
using Npgsql;

namespace MonitoringKopiKakao.Model
{
    public class PetugasModel
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string NamaPetugas { get; set; }

        private DatabaseConfig db = new DatabaseConfig();

        public DataTable GetAllPetugas()
        {
            string query = @"SELECT u.id_user AS ""ID"", u.username AS ""Username"", 
                             u.password AS ""Password"", pm.nama AS ""Nama Petugas""
                             FROM users u 
                             JOIN petugas_monitoring pm ON u.id_user = pm.id_user 
                             ORDER BY u.id_user DESC";
            return db.ExecuteQuery(query);
        }

        public void InsertPetugas()
        {
            
            string queryUser = "INSERT INTO users (id_user, username, password) VALUES (@id, @user, @pass)";
            string queryPetugas = "INSERT INTO petugas_monitoring (id_user, nama) VALUES (@id, @nama)";

            using (NpgsqlConnection conn = db.GetConnection())
            {
                using (NpgsqlCommand cmdUser = new NpgsqlCommand(queryUser, conn))
                {
                    cmdUser.Parameters.AddWithValue("@id", IdUser);
                    cmdUser.Parameters.AddWithValue("@user", Username);
                    cmdUser.Parameters.AddWithValue("@pass", Password);
                    cmdUser.ExecuteNonQuery();

                    using (NpgsqlCommand cmdPetugas = new NpgsqlCommand(queryPetugas, conn))
                    {
                        cmdPetugas.Parameters.AddWithValue("@id", IdUser);
                        cmdPetugas.Parameters.AddWithValue("@nama", NamaPetugas);
                        cmdPetugas.ExecuteNonQuery();
                    }
                }
            }
        }

        public void UpdatePetugas()
        {
            string queryUser = "UPDATE users SET username = @user, password = @pass WHERE id_user = @id";
            string queryPetugas = "UPDATE petugas_monitoring SET nama = @nama WHERE id_user = @id";

            using (NpgsqlConnection conn = db.GetConnection())
            {
                using (NpgsqlCommand cmdUser = new NpgsqlCommand(queryUser, conn))
                {
                    cmdUser.Parameters.AddWithValue("@id", IdUser);
                    cmdUser.Parameters.AddWithValue("@user", Username);
                    cmdUser.Parameters.AddWithValue("@pass", Password);
                    cmdUser.ExecuteNonQuery();
                }
                using (NpgsqlCommand cmdPetugas = new NpgsqlCommand(queryPetugas, conn))
                {
                    cmdPetugas.Parameters.AddWithValue("@id", IdUser);
                    cmdPetugas.Parameters.AddWithValue("@nama", NamaPetugas);
                    cmdPetugas.ExecuteNonQuery();
                }
            }
        }

        public void DeletePetugas(int id)
        {
            
            string query = "DELETE FROM users WHERE id_user = @id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@id", id);
                db.ExecuteNonQuery(cmd);
            }
        }
    }
}
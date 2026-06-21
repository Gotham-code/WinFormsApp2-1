using MonitoringKopiKakao;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using WinFormsApp2.View;

namespace WinFormsApp2
{
    public partial class LoginForm : Form
    {
        
        private DatabaseConfig db = new DatabaseConfig();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

        
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = db.GetConnection())
                {
                   
                    using (var cmd = new NpgsqlCommand("SELECT id_user, password FROM users WHERE username = @user", conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        using (var da = new NpgsqlDataAdapter(cmd))
                        {
                            var dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Username tidak terdaftar.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            var dbPassword = dt.Rows[0]["password"]?.ToString() ?? "";
                            var idUser = Convert.ToInt32(dt.Rows[0]["id_user"]);

                            if (dbPassword != password)
                            {
                                
                                MessageBox.Show("Password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            
                            using (var cmdRole = new NpgsqlCommand(@"SELECT 
                                        CASE WHEN a.id_user IS NOT NULL THEN 'Admin' WHEN p.id_user IS NOT NULL THEN 'Petugas' ELSE 'Unknown' END AS role,
                                        COALESCE(a.nama, p.nama) AS nama_lengkap
                                    FROM users u
                                    LEFT JOIN admin a ON u.id_user = a.id_user
                                    LEFT JOIN petugas_monitoring p ON u.id_user = p.id_user
                                    WHERE u.id_user = @id", conn))
                            {
                                cmdRole.Parameters.AddWithValue("@id", idUser);
                                using (var da2 = new NpgsqlDataAdapter(cmdRole))
                                {
                                    var dtRole = new DataTable();
                                    da2.Fill(dtRole);
                                    string role = "";
                                    string namaLengkap = "";
                                    if (dtRole.Rows.Count > 0)
                                    {
                                        role = dtRole.Rows[0]["role"]?.ToString() ?? "";
                                        namaLengkap = dtRole.Rows[0]["nama_lengkap"]?.ToString() ?? "";
                                    }

                                    Session.IdUser = idUser;
                                    Session.NamaLengkap = namaLengkap;

                                    MessageBox.Show($"Selamat Datang, {Session.NamaLengkap}!", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (role == "Admin")
                                    {
                                        DashboardAdmin formAdmin = new DashboardAdmin();
                                        formAdmin.Show();
                                        this.Hide();
                                    }
                                    else if (role == "Petugas")
                                    {
                                        DashboardPetugas formPetugas = new DashboardPetugas();
                                        formPetugas.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Role akun Anda tidak dikenali sistem.", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }


    public static class Session
    {
        public static int IdUser { get; set; }
        public static string NamaLengkap { get; set; } = "";
    }
}
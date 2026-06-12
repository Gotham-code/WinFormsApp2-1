using MonitoringKopiKakao;
using System;
using System.Data;
using System.Windows.Forms;
using WinFormsApp2.View;

namespace WinFormsApp2
{
    public partial class LoginForm : Form
    {
        // Deklarasikan objek 'db' untuk koneksi database
        private DatabaseConfig db = new DatabaseConfig();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mengambil teks yang diketik user di TextBox
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validasi sederhana jika field kosong
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // PERBAIKAN QUERY: Menyatukan data tabel 'users', 'admin', dan 'petugas_monitoring'
                // Kolom 'nama' dari masing-masing tabel anak digabung menjadi alias 'nama_lengkap'
                string query = $@"
            SELECT 
                u.id_user, 
                u.username, 
                CASE 
                    WHEN a.id_user IS NOT NULL THEN 'Admin'
                    WHEN p.id_user IS NOT NULL THEN 'Petugas'
                    ELSE 'Unknown'
                END AS role,
                COALESCE(a.nama, p.nama) AS nama_lengkap
            FROM users u
            LEFT JOIN admin a ON u.id_user = a.id_user
            LEFT JOIN petugas_monitoring p ON u.id_user = p.id_user
            WHERE u.username = '{username}' AND u.password = '{password}'";

                // Menjalankan query menggunakan method ExecuteQuery dari class DatabaseConfig
                DataTable hasil = db.ExecuteQuery(query);

                // Jika data ditemukan (artinya username & password benar)
                if (hasil.Rows.Count > 0)
                {
                    // Mengambil data role hasil dari query gabungan di atas
                    string role = hasil.Rows[0]["role"]?.ToString() ?? "";

                    // Menyimpan data user ke Session agar bisa digunakan di form lain
                    Session.IdUser = Convert.ToInt32(hasil.Rows[0]["id_user"]);
                    Session.NamaLengkap = hasil.Rows[0]["nama_lengkap"]?.ToString() ?? "";

                    MessageBox.Show($"Selamat Datang, {Session.NamaLengkap}!", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // --- PROSES ROUTING (PERPINDAHAN FORM) ---
                    if (role == "Admin")
                    {
                        DashboardAdmin formAdmin = new DashboardAdmin();
                        formAdmin.Show(); // Membuka Form Dashboard Admin
                        this.Hide();      // Menyembunyikan Form Login ini
                    }
                    else if (role == "Petugas")
                    {
                        DashboardPetugas formPetugas = new DashboardPetugas();
                        formPetugas.Show(); // Membuka Form Dashboard Petugas
                        this.Hide();        // Menyembunyikan Form Login ini
                    }
                    else
                    {
                        MessageBox.Show("Role akun Anda tidak dikenali sistem.", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    // Jika data tidak ditemukan
                    MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    // Class Session langsung berada di sini agar bisa diakses oleh LoginForm dan Form lainnya nanti
    public static class Session
    {
        public static int IdUser { get; set; }
        public static string NamaLengkap { get; set; } = "";
    }
}
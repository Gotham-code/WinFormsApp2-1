using System;
using System.Windows.Forms;
using WinFormsApp2.View; 

namespace WinFormsApp2
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }

      
        private void PindahHalaman(Form formTujuan)
        {

            this.splitContainer1.Panel2.Controls.Clear();


            formTujuan.TopLevel = false;
            formTujuan.FormBorderStyle = FormBorderStyle.None;
            formTujuan.Dock = DockStyle.Fill;


            this.splitContainer1.Panel2.Controls.Add(formTujuan);
            this.splitContainer1.Panel2.Tag = formTujuan;
            formTujuan.Show();
        }

      


        private void btnDashboard_Click(object sender, EventArgs e)
        {

            MenuUtamaAdmin formHome = new MenuUtamaAdmin();
            PindahHalaman(formHome);
        }

        private void btnTanaman_Click(object sender, EventArgs e)
        {

            Tanaman formTanaman = new Tanaman();
            PindahHalaman(formTanaman);
        }
        private void btnLahan_Click(object sender, EventArgs e)
        {

            Lahan formLahan = new Lahan();


            PindahHalaman(formLahan);
        }

        private void btnPetugas_Click(object sender, EventArgs e)
        {

            DataPetugas formPetugas = new DataPetugas();

            PindahHalaman(formPetugas);
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {

            Laporan formLaporan = new Laporan();


            PindahHalaman(formLaporan);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

   


        private void DashboardAdmin_Load(object sender, EventArgs e)
        {

            MenuUtamaAdmin formHome = new MenuUtamaAdmin();
            PindahHalaman(formHome);
        }
        private void label1_Click(object sender, EventArgs e) { }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) { }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
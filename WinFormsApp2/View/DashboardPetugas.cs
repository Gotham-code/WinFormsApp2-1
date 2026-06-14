using System;
using System.Windows.Forms;
using WinFormsApp2.View;

namespace WinFormsApp2
{
    public partial class DashboardPetugas : Form
    {
        public DashboardPetugas()
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

        private void DashboardPetugas_Load(object sender, EventArgs e)
        {
            MenuUtamaPetugas formHome = new MenuUtamaPetugas();
            PindahHalaman(formHome);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            PindahHalaman(new MenuUtamaPetugas());
        }

        private void btnInputMonitoring_Click(object sender, EventArgs e)
        {
            PindahHalaman(new InputMonitoring());
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            PindahHalaman(new RiwayatMonitoring());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e) { }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) { }
    }
}

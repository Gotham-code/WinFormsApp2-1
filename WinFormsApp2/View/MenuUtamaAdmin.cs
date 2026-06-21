using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MonitoringKopiKakao;
using WinFormsApp2.Models;

namespace WinFormsApp2.View
{
    public partial class MenuUtamaAdmin : Form
    {
        private DatabaseConfig db = new DatabaseConfig();

        public MenuUtamaAdmin()
        {
            InitializeComponent();
        }

        private void LoadDashboardData()
        {
            try
            {
                int jumlahTanaman = GetTotalTanaman();
                int jumlahLahan = GetTotalLahan();

                textBox2.Text = jumlahTanaman.ToString();
                textBox1.Text = jumlahLahan.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetTotalTanaman()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM tanaman";
                DataTable dt = db.ExecuteQuery(query);
                if (dt.Rows.Count > 0)
                {
                    return Convert.ToInt32(dt.Rows[0][0]);
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mendapatkan total tanaman: " + ex.Message);
            }
        }

        private int GetTotalLahan()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM lahan";
                DataTable dt = db.ExecuteQuery(query);
                if (dt.Rows.Count > 0)
                {
                    return Convert.ToInt32(dt.Rows[0][0]);
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mendapatkan total lahan: " + ex.Message);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadDashboardData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

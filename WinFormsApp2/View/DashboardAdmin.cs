using System;
using System.Windows.Forms;
using WinFormsApp2.View; // Memastikan folder View terdeteksi

namespace WinFormsApp2
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }

        // =======================================================
        // FUNGSI UTAMA: Memasukkan Form Anak ke Dalam SplitContainer Panel2
        // =======================================================
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

        // =======================================================
        // EVENT HANDLER: Klik Tombol Menu Utama
        // =======================================================

  
        private void button1_Click(object sender, EventArgs e)
        {
            
            MenuUtama formHome = new MenuUtama();
            PindahHalaman(formHome);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Tanaman formTanaman = new Tanaman();
            PindahHalaman(formTanaman);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            Lahan formLahan = new Lahan();

            
            PindahHalaman(formLahan);
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            
            DataPetugas formPetugas = new DataPetugas();

            PindahHalaman(formPetugas);
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
           
            Laporan formLaporan = new Laporan();

            
            PindahHalaman(formLaporan);
        }
        // =======================================================
        //  Error Designer
        // =======================================================


        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
        
            MenuUtama formHome = new MenuUtama();
            PindahHalaman(formHome);
        }
        private void label1_Click(object sender, EventArgs e) { }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) { }

        
        
    }
}
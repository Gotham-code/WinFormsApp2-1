using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2.View
{
    public partial class Laporan : Form
    {
        private WinFormsApp2.UserController.LaporanController controller;

        public Laporan()
        {
            InitializeComponent();
            controller = new WinFormsApp2.UserController.LaporanController(this);
            Load += Laporan_Load;
        }

        private void Laporan_Load(object sender, EventArgs e)
        {
            controller.TampilData();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2.View
{
    public partial class MenuUtamaPetugas : Form
    {
        public MenuUtamaPetugas()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            lblMonitoringCount.Text = "5";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

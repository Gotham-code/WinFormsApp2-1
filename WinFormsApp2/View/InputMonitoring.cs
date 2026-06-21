using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2.View
{
    public partial class InputMonitoring : Form
    {
        private WinFormsApp2.UserController.MonitoringController controller;

        public InputMonitoring()
        {
            InitializeComponent();
            controller = new WinFormsApp2.UserController.MonitoringController(this);
            Load += InputMonitoring_Load;
        }

        private void InputMonitoring_Load(object sender, EventArgs e)
        {
            controller.TampilDataInput();
            // Muat data untuk combo box dari database jika tersedia
            try { controller.LoadDropdowns(); } catch { /* ignore if db not available */ }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            controller.SimpanFromInput();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Implement edit flow later (fill model from fields then call Update)
            MessageBox.Show("Edit feature belum diimplementasikan");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // clear inputs
            textBox1?.Clear();
            textBox2?.Clear();
            comboBoxTanaman?.SelectedIndex = -1;
            comboBoxPetugas?.SelectedIndex = -1;
            comboBox1?.SelectedIndex = -1;
            comboBox2?.SelectedIndex = -1;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
        }

        private void comboBoxPetugas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

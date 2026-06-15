namespace WinFormsApp2.View
{
    partial class RiwayatMonitoring
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RiwayatMonitoring));
            panel1 = new Panel();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            btnRefresh = new Button();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox3);
            panel1.Location = new Point(64, 45);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 117);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(502, 35);
            textBox3.Margin = new Padding(5);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Nama Tanaman";
            textBox3.Size = new Size(201, 39);
            textBox3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(64, 300);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(727, 322);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(180, 203);
            btnDelete.Margin = new Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(122, 48);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Hapus";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(366, 203);
            btnRefresh.Margin = new Padding(5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(122, 48);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(40, 35);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 39);
            dateTimePicker1.TabIndex = 3;
            // 
            // RiwayatMonitoring
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1300, 720);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new Padding(5);
            Name = "RiwayatMonitoring";
            Text = "RiwayatMonitoring";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public TextBox textBox3;
        public DataGridView dataGridView1;
        public Button btnDelete;
        public Button btnRefresh;
        private DateTimePicker dateTimePicker1;
    }
}
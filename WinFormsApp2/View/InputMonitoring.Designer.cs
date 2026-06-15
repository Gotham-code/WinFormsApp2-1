namespace WinFormsApp2.View
{
    partial class InputMonitoring
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputMonitoring));
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            textBoxId = new TextBox();
            comboBoxTanaman = new ComboBox();
            comboBoxPetugas = new ComboBox();
            dataGridView1 = new DataGridView();
            btnSave = new Button();
            btnEdit = new Button();
            btnReset = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBoxId);
            panel1.Controls.Add(comboBoxTanaman);
            panel1.Controls.Add(comboBoxPetugas);
            panel1.Location = new Point(36, 40);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(769, 207);
            panel1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.Items.AddRange(new object[] { "Cerah", "Hujan" });
            comboBox2.Location = new Point(509, 133);
            comboBox2.Margin = new Padding(5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(201, 40);
            comboBox2.TabIndex = 10;
            comboBox2.Text = " Cuaca";
            // 
            // comboBox1
            // 
            comboBox1.Items.AddRange(new object[] { "Ulat", "Tidak Ada" });
            comboBox1.Location = new Point(509, 35);
            comboBox1.Margin = new Padding(5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 40);
            comboBox1.TabIndex = 9;
            comboBox1.Text = "Hama";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(26, 131);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(201, 39);
            dateTimePicker1.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 35);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Id Monitoring";
            textBox1.Size = new Size(201, 39);
            textBox1.TabIndex = 0;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(0, 0);
            textBoxId.Margin = new Padding(5);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(14, 39);
            textBoxId.TabIndex = 6;
            textBoxId.Visible = false;
            // 
            // comboBoxTanaman
            // 
            comboBoxTanaman.Items.AddRange(new object[] { "Kopi", "Kakao" });
            comboBoxTanaman.Location = new Point(257, 35);
            comboBoxTanaman.Margin = new Padding(5);
            comboBoxTanaman.Name = "comboBoxTanaman";
            comboBoxTanaman.Size = new Size(201, 40);
            comboBoxTanaman.TabIndex = 6;
            comboBoxTanaman.Text = "Jenis tanaman";
            // 
            // comboBoxPetugas
            // 
            comboBoxPetugas.Items.AddRange(new object[] { "Sehat", "Layu" });
            comboBoxPetugas.Location = new Point(257, 133);
            comboBoxPetugas.Margin = new Padding(5);
            comboBoxPetugas.Name = "comboBoxPetugas";
            comboBoxPetugas.Size = new Size(201, 40);
            comboBoxPetugas.TabIndex = 7;
            comboBoxPetugas.Text = "Kondisi";
            comboBoxPetugas.SelectedIndexChanged += comboBoxPetugas_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 352);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(769, 319);
            dataGridView1.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(111, 276);
            btnSave.Margin = new Padding(5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 48);
            btnSave.TabIndex = 0;
            btnSave.Text = "Simpan";
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(317, 276);
            btnEdit.Margin = new Padding(5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(122, 48);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Ubah";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(502, 276);
            btnReset.Margin = new Padding(5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(122, 48);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.Click += btnReset_Click;
            // 
            // InputMonitoring
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1300, 720);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(btnReset);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new Padding(5);
            Name = "InputMonitoring";
            Text = "Monitoring";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public TextBox textBox1;
        public DataGridView dataGridView1;
        public TextBox textBoxId;
        public ComboBox comboBoxTanaman;
        public ComboBox comboBoxPetugas;
        public Button btnSave;
        public Button btnEdit;
        public Button btnReset;
        public ComboBox comboBox2;
        public ComboBox comboBox1;
        public DateTimePicker dateTimePicker1;
    }
}
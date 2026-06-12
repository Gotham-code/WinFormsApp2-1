namespace WinFormsApp2
{
    partial class DashboardAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        // Method untuk memasukkan Form ke dalam PanelKonten
        
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdmin));
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(405, 204);
            panel2.Name = "panel2";
            panel2.Size = new Size(214, 119);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(19, 8);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 0;
            label1.Text = "JUMLAH TANAMAN\r\n";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(91, 204);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 123);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(16, 8);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 1;
            label2.Text = "JUMLAH LAHAN";
            // 
            // button1
            // 
            button1.Location = new Point(76, 169);
            button1.Name = "button1";
            button1.Size = new Size(190, 29);
            button1.TabIndex = 3;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(76, 204);
            button2.Name = "button2";
            button2.Size = new Size(190, 29);
            button2.TabIndex = 4;
            button2.Text = "Data Tanaman";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(76, 239);
            button3.Name = "button3";
            button3.Size = new Size(190, 29);
            button3.TabIndex = 5;
            button3.Text = "Data Lahan";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(76, 274);
            button4.Name = "button4";
            button4.Size = new Size(190, 29);
            button4.TabIndex = 6;
            button4.Text = "Data Petugas";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(76, 309);
            button5.Name = "button5";
            button5.Size = new Size(190, 28);
            button5.TabIndex = 7;
            button5.Text = "Laporan";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(76, 434);
            button6.Name = "button6";
            button6.Size = new Size(190, 28);
            button6.TabIndex = 8;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.Transparent;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackgroundImage = Properties.Resources.bg_kiri;
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(button6);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(button5);
            splitContainer1.Panel1.Controls.Add(button4);
            splitContainer1.Panel1.Controls.Add(button3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel2.BackgroundImage");
            splitContainer1.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1035, 563);
            splitContainer1.SplitterDistance = 344;
            splitContainer1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(91, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(517, 131);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.NavajoWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1035, 563);
            Controls.Add(splitContainer1);
            DoubleBuffered = true;
            Name = "DashboardAdmin";
            Text = "Form1";
            Load += DashboardAdmin_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
    }
}

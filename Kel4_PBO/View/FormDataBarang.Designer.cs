
namespace Kel4_PBO.View
{
    partial class DataBarang
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
            label1 = new Label();
            panelContent = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            dataGridviewBarang = new DataGridView();
            textBox9 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panelMenu = new Panel();
            iconButtonPesanan = new FontAwesome.Sharp.IconButton();
            iconButtonDataBarang = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            labelHomeApp = new Label();
            pictureBoxHome = new PictureBox();
            textBox3 = new TextBox();
            panelContent.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridviewBarang).BeginInit();
            panelMenu.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(507, 315);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 0;
            label1.Text = "data barang";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(35, 35, 35);
            panelContent.Controls.Add(panel2);
            panelContent.Controls.Add(labelHomeApp);
            panelContent.Controls.Add(pictureBoxHome);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Margin = new Padding(4, 5, 4, 5);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1126, 883);
            panelContent.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 35, 35);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(panelMenu);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1126, 883);
            panel2.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(dataGridviewBarang);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(365, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(735, 467);
            panel1.TabIndex = 9;
            // 
            // dataGridviewBarang
            // 
            dataGridviewBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridviewBarang.Location = new Point(63, 93);
            dataGridviewBarang.Name = "dataGridviewBarang";
            dataGridviewBarang.RowHeadersWidth = 62;
            dataGridviewBarang.Size = new Size(632, 296);
            dataGridviewBarang.TabIndex = 12;
            dataGridviewBarang.CellContentClick += dataGridviewBarang_CellContentClick;
            // 
            // textBox9
            // 
            textBox9.BackColor = SystemColors.WindowText;
            textBox9.ForeColor = SystemColors.Window;
            textBox9.Location = new Point(567, 15);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(56, 31);
            textBox9.TabIndex = 8;
            textBox9.Text = "  Cari";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.WindowText;
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(216, 15);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(69, 31);
            textBox2.TabIndex = 1;
            textBox2.Text = "    edit";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.WindowText;
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(35, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 31);
            textBox1.TabIndex = 0;
            textBox1.Text = " + Tambah";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Black;
            panelMenu.Controls.Add(iconButtonPesanan);
            panelMenu.Controls.Add(iconButtonDataBarang);
            panelMenu.Controls.Add(iconButton1);
            panelMenu.Controls.Add(iconButton2);
            panelMenu.Controls.Add(panel3);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(4, 5, 4, 5);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(301, 883);
            panelMenu.TabIndex = 8;
            // 
            // iconButtonPesanan
            // 
            iconButtonPesanan.Dock = DockStyle.Top;
            iconButtonPesanan.FlatAppearance.BorderSize = 0;
            iconButtonPesanan.FlatStyle = FlatStyle.Flat;
            iconButtonPesanan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButtonPesanan.ForeColor = Color.FromArgb(255, 102, 36);
            iconButtonPesanan.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            iconButtonPesanan.IconColor = Color.FromArgb(255, 102, 36);
            iconButtonPesanan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonPesanan.IconSize = 35;
            iconButtonPesanan.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonPesanan.Location = new Point(0, 413);
            iconButtonPesanan.Margin = new Padding(4, 5, 4, 5);
            iconButtonPesanan.Name = "iconButtonPesanan";
            iconButtonPesanan.Padding = new Padding(43, 0, 0, 0);
            iconButtonPesanan.Size = new Size(301, 100);
            iconButtonPesanan.TabIndex = 4;
            iconButtonPesanan.Text = "Transaksi";
            iconButtonPesanan.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonPesanan.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonPesanan.UseVisualStyleBackColor = true;
            // 
            // iconButtonDataBarang
            // 
            iconButtonDataBarang.Dock = DockStyle.Top;
            iconButtonDataBarang.FlatAppearance.BorderSize = 0;
            iconButtonDataBarang.FlatStyle = FlatStyle.Flat;
            iconButtonDataBarang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButtonDataBarang.ForeColor = Color.White;
            iconButtonDataBarang.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            iconButtonDataBarang.IconColor = Color.FromArgb(255, 102, 36);
            iconButtonDataBarang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonDataBarang.IconSize = 35;
            iconButtonDataBarang.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonDataBarang.Location = new Point(0, 313);
            iconButtonDataBarang.Margin = new Padding(4, 5, 4, 5);
            iconButtonDataBarang.Name = "iconButtonDataBarang";
            iconButtonDataBarang.Padding = new Padding(43, 0, 0, 0);
            iconButtonDataBarang.Size = new Size(301, 100);
            iconButtonDataBarang.TabIndex = 3;
            iconButtonDataBarang.Text = "Data Barang";
            iconButtonDataBarang.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonDataBarang.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonDataBarang.UseVisualStyleBackColor = true;
            iconButtonDataBarang.Click += iconButtonDataBarang_Click1;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.FromArgb(255, 102, 36);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            iconButton1.IconColor = Color.FromArgb(255, 102, 36);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 35;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 213);
            iconButton1.Margin = new Padding(4, 5, 4, 5);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(43, 0, 0, 0);
            iconButton1.Size = new Size(301, 100);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "Kotak Masuk";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.ForeColor = Color.FromArgb(255, 102, 36);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            iconButton2.IconColor = Color.FromArgb(255, 102, 36);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 35;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 113);
            iconButton2.Margin = new Padding(4, 5, 4, 5);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(43, 0, 0, 0);
            iconButton2.Size = new Size(301, 100);
            iconButton2.TabIndex = 1;
            iconButton2.Text = "Dashboard";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(301, 113);
            panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(44, 47);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(113, 55);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 3;
            label3.Text = "KINK";
            // 
            // panel4
            // 
            panel4.Location = new Point(381, 5);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(747, 313);
            panel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(365, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(224, 48);
            label2.TabIndex = 6;
            label2.Text = "Stok Barang";
            label2.Click += label2_Click2;
            // 
            // labelHomeApp
            // 
            labelHomeApp.AutoSize = true;
            labelHomeApp.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHomeApp.ForeColor = Color.White;
            labelHomeApp.Location = new Point(461, 568);
            labelHomeApp.Margin = new Padding(4, 0, 4, 0);
            labelHomeApp.Name = "labelHomeApp";
            labelHomeApp.Size = new Size(164, 48);
            labelHomeApp.TabIndex = 6;
            labelHomeApp.Text = "KinkApp";
            // 
            // pictureBoxHome
            // 
            pictureBoxHome.Image = Properties.Resources.logo;
            pictureBoxHome.Location = new Point(436, 300);
            pictureBoxHome.Margin = new Padding(4, 5, 4, 5);
            pictureBoxHome.Name = "pictureBoxHome";
            pictureBoxHome.Size = new Size(214, 250);
            pictureBoxHome.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHome.TabIndex = 5;
            pictureBoxHome.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.WindowText;
            textBox3.ForeColor = SystemColors.Window;
            textBox3.Location = new Point(303, 15);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(88, 31);
            textBox3.TabIndex = 13;
            textBox3.Text = "   hapus";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // DataBarang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(1126, 883);
            Controls.Add(panelContent);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DataBarang";
            Text = "Data Barang";
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridviewBarang).EndInit();
            panelMenu.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void iconButtonDataBarang_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click2(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Panel panelContent;
        private Label labelHomeApp;
        private PictureBox pictureBoxHome;
        private Panel panel2;
        private Label label2;
        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonPesanan;
        private FontAwesome.Sharp.IconButton iconButtonDataBarang;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label3;
        private Panel panel4;
        private Panel panel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox9;
        private DataGridView dataGridviewBarang;
        private TextBox textBox3;
    }
}
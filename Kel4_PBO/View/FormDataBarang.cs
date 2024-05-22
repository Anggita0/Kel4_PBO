using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Kel4_PBO.View.DataBarang;
using Kel4_PBO.Model;

namespace Kel4_PBO.View
{
    public partial class DataBarang : Form
    {

        public DataBarang()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dataGridviewBarang.DataSource = Barang.DataBarang;
        }

        private void dataGridviewBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}











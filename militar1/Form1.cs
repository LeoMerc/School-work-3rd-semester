using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace militar1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"server=.; Initial Catalog = militar; integrated security = true");
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Flag_of_Mexico.svg/200px-Flag_of_Mexico.svg.png";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 a = new Form2(); a.Show(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 a = new Form3(); a.Show();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form5 a = new Form5(); a.Show();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form4 a = new Form4(); a.Show();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form6 a = new Form6(); a.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Reportes_Click(object sender, EventArgs e)
        {
        }
    }
}

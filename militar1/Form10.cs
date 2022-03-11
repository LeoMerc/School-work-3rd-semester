using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace militar1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MilitarDataSet.Soldados' table. You can move, or remove it, as needed.
            this.SoldadosTableAdapter.Fill(this.MilitarDataSet.Soldados);

            this.reportViewer1.RefreshReport();
        }
    }
}

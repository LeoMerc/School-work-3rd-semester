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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MilitarDataSet.Sede' table. You can move, or remove it, as needed.
            this.SedeTableAdapter.Fill(this.MilitarDataSet.Sede);

            this.reportViewer1.RefreshReport();
        }
    }
}

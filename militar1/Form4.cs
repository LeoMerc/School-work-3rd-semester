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
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"server=.; Initial Catalog =Militar; integrated security = true");
        TextBox text = new TextBox();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'militarDataSet.Armamento' table. You can move, or remove it, as needed.
            this.armamentoTableAdapter.Fill(this.militarDataSet.Armamento);

            SqlCommand cons = new SqlCommand("Select CURP_SOLDADOS From Soldados", con);
            con.Open();
            cons.Parameters.AddWithValue("CURP_SOLDADOS", comboBox1.Text);
            SqlDataReader reader = cons.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["CURP_SOLDADOS"]);


            }

            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand alt = new SqlCommand("insert into Armamento (Id_armamento, FechaDeMantenimiento_Armamentos, TipoMunicion_ARMAMENTO, CURP_SOLDADOS) values (@Id_armamento, @FechaDeMantenimiento_Armamentos, @TipoMunicion_ARMAMENTO, @CURP_SOLDADOS)", con);
                alt.Parameters.AddWithValue("Id_armamento", textBox1.Text);
                alt.Parameters.AddWithValue("FechaDeMantenimiento_Armamentos", textBox2.Text);
                alt.Parameters.AddWithValue("TipoMunicion_ARMAMENTO", textBox3.Text);
                alt.Parameters.AddWithValue("CURP_SOLDADOS", comboBox1.Text);

                con.Open();
                alt.ExecuteNonQuery();
                con.Close();

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        text = ctrl as TextBox;
                        text.Clear();
                    }
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            comboBox1.Text = null;
            this.armamentoTableAdapter.Fill(this.militarDataSet.Armamento);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string modi = "UPDATE Armamento Set Id_armamento=@Id_armamento,FechaDeMantenimiento_Armamentos=@FechaDeMantenimiento_Armamentos, TipoMunicion_ARMAMENTO=@TipoMunicion_ARMAMENTO, CURP_SOLDADOS=@CURP_SOLDADOS WHERE Id_armamento=@Id_armamento";
                SqlCommand mod = new SqlCommand(modi, con);
                mod.Parameters.AddWithValue("Id_armamento", textBox1.Text);
                mod.Parameters.AddWithValue("FechaDeMantenimiento_Armamentos", textBox2.Text);
                mod.Parameters.AddWithValue("TipoMunicion_ARMAMENTO", textBox3.Text);
                mod.Parameters.AddWithValue("CURP_SOLDADOS", comboBox1.Text);


                mod.ExecuteNonQuery();
                MessageBox.Show("Modificacion completa");
                con.Close();
            }

            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            comboBox1.Text = null;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    text = ctrl as TextBox;
                    text.Clear();

                }
            }
            this.armamentoTableAdapter.Fill(this.militarDataSet.Armamento);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string baja = "DELETE FROM Armamento Where Id_armamento = @Id_armamento";
                con.Open();
                SqlCommand cmdins = new SqlCommand(baja, con);
                cmdins.Parameters.AddWithValue("Id_armamento", textBox1.Text);
                cmdins.ExecuteNonQuery();
                cmdins.Dispose();
                cmdins = null;
                con.Close();
                MessageBox.Show("Se ha eliminado");
            }

            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            comboBox1.Text = null;
            this.armamentoTableAdapter.Fill(this.militarDataSet.Armamento);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string bus = "SELECT * FROM Armamento Where Id_armamento=@Id_armamento";
                SqlCommand cons = new SqlCommand(bus, con);
                con.Open();
                cons.Parameters.AddWithValue("@Id_armamento", textBox1.Text);
                SqlDataReader reader = cons.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader[0].ToString();
                    textBox2.Text = reader[1].ToString();
                    textBox3.Text = reader[2].ToString();
                    comboBox1.Text = reader[3].ToString();
                }

                MessageBox.Show("Consulta lista");
                con.Close();
            }

            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 asd = new Form7(); asd.Show();

        }
    }
}

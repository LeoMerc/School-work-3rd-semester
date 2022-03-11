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
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection(@"server=.; Initial Catalog =Militar; integrated security = true");
        TextBox text = new TextBox();

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'militarDataSet.Soldados' table. You can move, or remove it, as needed.
            this.soldadosTableAdapter.Fill(this.militarDataSet.Soldados);

            SqlCommand cons = new SqlCommand("Select Id_sede From Sede", con);
            con.Open();
            cons.Parameters.AddWithValue("Id_sede", comboBox2.Text);
            SqlDataReader reader = cons.ExecuteReader();

            while (reader.Read())
            {
                comboBox2.Items.Add(reader["Id_sede"]);


            }

            con.Close();

            SqlCommand cons2 = new SqlCommand("Select Id_INVESTIGACIONES From Investigaciones", con);
            con.Open();
            cons2.Parameters.AddWithValue("Id_investigaciones", comboBox1.Text);
            SqlDataReader reader2 = cons2.ExecuteReader();

            while (reader2.Read())
            {
                comboBox1.Items.Add(reader2["Id_investigaciones"]);


            }

            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand alt = new SqlCommand("insert into Soldados (CURP_SOLDADOS,Domicilio_soldados,Edad_soldados,Sexo_soldados,Telefono_soldados,Id_sede,Id_investigaciones) values (@CURP_SOLDADOS,@Domicilio_soldados,@Edad_soldados,@Sexo_soldados,@Telefono_soldados,@Id_sede,@Id_investigaciones)", con);
                alt.Parameters.AddWithValue("CURP_SOLDADOS", textBox20.Text);
                alt.Parameters.AddWithValue("Domicilio_soldados", textBox10.Text);
                alt.Parameters.AddWithValue("Edad_soldados", textBox11.Text);
                alt.Parameters.AddWithValue("Sexo_soldados", textBox3.Text);
                alt.Parameters.AddWithValue("Telefono_soldados", textBox1.Text);
                alt.Parameters.AddWithValue("Id_sede", comboBox2.Text);
                alt.Parameters.AddWithValue("Id_investigaciones", comboBox1.Text);

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
                comboBox1.Text = null;
                comboBox2.Text = null;

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            this.soldadosTableAdapter.Fill(this.militarDataSet.Soldados);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string modi = "UPDATE Soldados Set CURP_SOLDADOS=@CURP_SOLDADOS,Domicilio_soldados=@Domicilio_soldados, Edad_soldados=@Edad_soldados, Sexo_soldados=@Sexo_soldados, Telefono_soldados=@Telefono_soldados, Id_sede=@Id_sede, Id_investigaciones=@Id_investigaciones  WHERE CURP_SOLDADOS=@CURP_SOLDADOS";
                SqlCommand mod = new SqlCommand(modi, con);
                mod.Parameters.AddWithValue("CURP_SOLDADOS", textBox20.Text);
                mod.Parameters.AddWithValue("Domicilio_soldados", textBox10.Text);
                mod.Parameters.AddWithValue("Edad_soldados", textBox11.Text);
                mod.Parameters.AddWithValue("Sexo_soldados", textBox3.Text);
                mod.Parameters.AddWithValue("Telefono_soldados", textBox1.Text);
                mod.Parameters.AddWithValue("Id_sede", comboBox2.Text);
                mod.Parameters.AddWithValue("Id_investigaciones", comboBox1.Text);
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
            this.soldadosTableAdapter.Fill(this.militarDataSet.Soldados);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string bus = "SELECT * FROM Soldados Where CURP_SOLDADOS=@CURP_SOLDADOS";
                SqlCommand cons = new SqlCommand(bus, con);
                con.Open();
                cons.Parameters.AddWithValue("@CURP_SOLDADOS", textBox20.Text);
                SqlDataReader reader = cons.ExecuteReader();
                while (reader.Read())
                {
                    textBox20.Text = reader[0].ToString();
                    textBox10.Text = reader[1].ToString();
                    textBox11.Text = reader[2].ToString();
                    textBox3.Text = reader[3].ToString();
                    textBox1.Text = reader[4].ToString();
                    comboBox2.Text = reader[5].ToString();
                    comboBox1.Text = reader[6].ToString();
                }

                MessageBox.Show("Consulta lista");
                con.Close();
            }

            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string baja = "DELETE FROM Soldados Where CURP_SOLDADOS = @CURP_SOLDADOS";
                con.Open();
                SqlCommand cmdins = new SqlCommand(baja, con);
                cmdins.Parameters.AddWithValue("CURP_SOLDADOS", textBox20.Text);
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
            comboBox2.Text = null;

            this.soldadosTableAdapter.Fill(this.militarDataSet.Soldados);


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form10 asd = new Form10(); asd.Show();

        }
    }
}

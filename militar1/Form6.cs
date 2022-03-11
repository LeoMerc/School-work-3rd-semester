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
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection(@"server=.; Initial Catalog =Militar; integrated security = true");
        TextBox text = new TextBox();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'militarDataSet.Vehiculos' table. You can move, or remove it, as needed.
            this.vehiculosTableAdapter.Fill(this.militarDataSet.Vehiculos);

            SqlCommand cons = new SqlCommand("Select Id_sede From Sede", con);
            con.Open();
            cons.Parameters.AddWithValue("Id_sede", comboBox1.Text);
            SqlDataReader reader = cons.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Id_sede"]);

            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand alt = new SqlCommand("insert into Vehiculos (Id_vehiculos, Color_Vehiculos, Tipo_Vechiculos, FechaUltimoMant_Vehiculos, Id_sede ) values (@Id_vehiculos, @Color_Vehiculos, @Tipo_Vechiculos, @FechaUltimoMant_Vehiculos, @Id_sede)", con);
                alt.Parameters.AddWithValue("Id_vehiculos", textBox25.Text);
                alt.Parameters.AddWithValue("Color_Vehiculos", textBox26.Text);
                alt.Parameters.AddWithValue("Tipo_Vechiculos", textBox2.Text);
                alt.Parameters.AddWithValue("FechaUltimoMant_Vehiculos", textBox1.Text);
                alt.Parameters.AddWithValue("Id_sede", comboBox1.Text);
                
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
                this.vehiculosTableAdapter.Fill(this.militarDataSet.Vehiculos);

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string modi = "UPDATE Vehiculos Set Id_vehiculos=@Id_vehiculos, Color_Vehiculos = @Color_Vehiculos, Tipo_Vechiculos=@Tipo_Vechiculos, FechaUltimoMant_Vehiculos=@FechaUltimoMant_Vehiculos, Id_sede=@Id_sede WHERE Id_vehiculos=@Id_vehiculos";
                SqlCommand mod = new SqlCommand(modi, con);
                mod.Parameters.AddWithValue("Id_vehiculos", textBox25.Text);
                mod.Parameters.AddWithValue("Color_Vehiculos", textBox26.Text);
                mod.Parameters.AddWithValue("Tipo_Vechiculos", textBox2.Text);
                mod.Parameters.AddWithValue("FechaUltimoMant_Vehiculos", textBox1.Text);
                mod.Parameters.AddWithValue("Id_sede", comboBox1.Text);
                
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
            this.vehiculosTableAdapter.Fill(this.militarDataSet.Vehiculos);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string baja = "DELETE FROM Vehiculos Where Id_vehiculos = @Id_vehiculos";
                con.Open();
                SqlCommand cmdins = new SqlCommand(baja, con);
                cmdins.Parameters.AddWithValue("Id_vehiculos", textBox25.Text);
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
            this.vehiculosTableAdapter.Fill(this.militarDataSet.Vehiculos);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string bus = "SELECT * FROM Vehiculos Where Id_vehiculos=@Id_vehiculos";
                SqlCommand cons = new SqlCommand(bus, con);
                con.Open();
                cons.Parameters.AddWithValue("@Id_vehiculos", textBox25.Text);
                SqlDataReader reader = cons.ExecuteReader();
                while (reader.Read())
                {
                    textBox25.Text = reader[0].ToString();
                    textBox26.Text = reader[1].ToString();
                    textBox2.Text = reader[2].ToString();
                    textBox1.Text = reader[3].ToString();
                    comboBox1.Text = reader[4].ToString();


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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form11 asd = new Form11(); asd.Show();

        }
    }
}

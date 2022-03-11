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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"server=.; Initial Catalog =Militar; integrated security = true");
        TextBox text = new TextBox();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
     
            
            // TODO: This line of code loads data into the 'militarDataSet.Investigaciones' table. You can move, or remove it, as needed.
            this.investigacionesTableAdapter.Fill(this.militarDataSet.Investigaciones);

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

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand alt = new SqlCommand("insert into Investigaciones (Id_INVESTIGACIONES, Lugar_INVESTIGACIONES, Fecha_INVESTIGACIONESs, Id_sede) values (@Id_INVESTIGACIONES, @Lugar_INVESTIGACIONES, @Fecha_INVESTIGACIONESs, @Id_sede)", con);
                alt.Parameters.AddWithValue("Id_INVESTIGACIONES", textBox25.Text);
                alt.Parameters.AddWithValue("Lugar_INVESTIGACIONES", textBox26.Text);
                alt.Parameters.AddWithValue("Fecha_INVESTIGACIONESs", textBox2.Text);
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

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            comboBox1.Text = null;

            this.investigacionesTableAdapter.Fill(this.militarDataSet.Investigaciones);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string modi = "UPDATE Investigaciones Set Id_INVESTIGACIONES=@Id_INVESTIGACIONES,Lugar_INVESTIGACIONES=@Lugar_INVESTIGACIONES, Fecha_INVESTIGACIONESs=@Fecha_INVESTIGACIONESs, Id_sede=@Id_sede WHERE Id_INVESTIGACIONES=@Id_INVESTIGACIONES";
                SqlCommand mod = new SqlCommand(modi, con);
                mod.Parameters.AddWithValue("Id_INVESTIGACIONES", textBox25.Text);
                mod.Parameters.AddWithValue("Lugar_INVESTIGACIONES", textBox26.Text);
                mod.Parameters.AddWithValue("Fecha_INVESTIGACIONESs", textBox2.Text);
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
            this.investigacionesTableAdapter.Fill(this.militarDataSet.Investigaciones);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string baja = "DELETE FROM Investigaciones Where Id_investigaciones = @Id_investigaciones";
                con.Open();
                SqlCommand cmdins = new SqlCommand(baja, con);
                cmdins.Parameters.AddWithValue("Id_investigaciones", textBox25.Text);
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

            this.investigacionesTableAdapter.Fill(this.militarDataSet.Investigaciones);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string bus = "SELECT * FROM Investigaciones Where Id_investigaciones=@Id_investigaciones";
                SqlCommand cons = new SqlCommand(bus, con);
                con.Open();
                cons.Parameters.AddWithValue("@Id_investigaciones", textBox25.Text);
                SqlDataReader reader = cons.ExecuteReader();
                while (reader.Read())
                {
                    textBox25.Text = reader[0].ToString();
                    textBox26.Text = reader[1].ToString();
                    textBox2.Text = reader[2].ToString();
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
            Form8 asd = new Form8(); asd.Show();
        }
    }
}

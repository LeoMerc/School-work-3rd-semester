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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"server=.; Initial Catalog =Militar; integrated security = true");
        TextBox text = new TextBox();
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'militarDataSet.Sede' table. You can move, or remove it, as needed.
            this.sedeTableAdapter.Fill(this.militarDataSet.Sede);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand alt = new SqlCommand("insert into Sede (Id_SEDE, Ubicacion_SEDEvarchar, NumDeSoldados_SEDE) values (@Id_SEDE, @Ubicacion_SEDEvarchar, @NumDeSoldados_SEDE)", con);
                alt.Parameters.AddWithValue("Id_SEDE", textBox1.Text);
                alt.Parameters.AddWithValue("Ubicacion_SEDEvarchar", textBox2.Text);
                alt.Parameters.AddWithValue("NumDeSoldados_SEDE", textBox3.Text);
                con.Open();
                alt.ExecuteNonQuery();
                con.Close();

                foreach(Control ctrl in this.Controls)
                {
                    if(ctrl is TextBox)
                    {
                        text = ctrl as TextBox;
                        text.Clear(); 
                    }
                }
                this.sedeTableAdapter.Fill(this.militarDataSet.Sede);

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
                string baja = "DELETE FROM Sede Where Id_SEDE = @Id_SEDE";
                con.Open();
                SqlCommand cmdins = new SqlCommand(baja, con);
                cmdins.Parameters.AddWithValue("Id_SEDE", textBox1.Text);
                cmdins.ExecuteNonQuery();
                cmdins.Dispose();
                cmdins = null;
                con.Close();
                MessageBox.Show("Se ha eliminado");
                this.sedeTableAdapter.Fill(this.militarDataSet.Sede);
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string bus = "SELECT * FROM Sede Where Id_SEDE=@Id_SEDE";
                SqlCommand cons = new SqlCommand(bus, con);
                con.Open();
                cons.Parameters.AddWithValue("@Id_SEDE", textBox1.Text);
                SqlDataReader reader = cons.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader[0].ToString();
                    textBox2.Text = reader[1].ToString();
                    textBox3.Text = reader[2].ToString();
                }

                MessageBox.Show("Consulta lista");
                con.Close();
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
                string modi = "UPDATE Sede Set Id_SEDE=@Id_SEDE, Ubicacion_SEDEvarchar = @Ubicacion_SEDEvarchar, NumDeSoldados_SEDE=@NumDeSoldados_SEDE WHERE Id_SEDE=@Id_SEDE";
                SqlCommand mod = new SqlCommand(modi, con);
                mod.Parameters.AddWithValue("Id_SEDE", textBox1.Text);
                mod.Parameters.AddWithValue("Ubicacion_SEDEvarchar", textBox2.Text);
                mod.Parameters.AddWithValue("NumDeSoldados_SEDE", textBox3.Text);
                mod.ExecuteNonQuery();
                MessageBox.Show("Modificacion completa");
                con.Close();
            }

            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is TextBox)
                {
                    text = ctrl as TextBox;
                    text.Clear();
                }
            }
            this.sedeTableAdapter.Fill(this.militarDataSet.Sede);


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form9 asd = new Form9(); asd.Show();

        }
    }

}

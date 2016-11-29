using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// manuales

using System.Configuration;
using System.Data.SqlClient;

namespace Nomina
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string filtro;
        
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            }

        void carga_datos(string filtro)

        {

            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SqlConnection conexion = new SqlConnection(con);
            DataSet ds = new DataSet();
            string sql = "select * from empleado" + filtro;

            try
            {
                conexion.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conexion);
                adapter.Fill(ds, "empleado");

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "empleado";

                conexion.Close();
            }
            catch (Exception ex)
            {

                textBox2.Text = ex.Message.ToString();
            }
            finally
            {
                conexion.Close();
            }

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (rad_Id.Checked)
            {
                filtro = "id=";
                carga_filtro();
                textBox1.Clear();

            }

            else if (rad_Nom.Checked)
            {
                filtro = "nombre like ";
                carga_filtro2();
                textBox1.Clear();
            }

            else if (rad_Ape.Checked)
            {
                filtro = "apellido like ";
                carga_filtro2();
                textBox1.Clear();
            }

            else if (rad_Cedu.Checked)
            {
                filtro = "cedula like ";
                carga_filtro2();
                textBox1.Clear();
            }

            else
                
            carga_datos("");
        }

        private void rad_Id_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        void carga_filtro ()
        {
            string texto = textBox1.Text.ToString();
            string num_id = " where " + filtro + "'" + texto + "'" + ";";
            carga_datos(num_id);
        }

        void carga_filtro2()
        {
            string texto = textBox1.Text.ToString();
            string num_id = " where " + filtro + "'%" + texto + "%'" + ";";
            carga_datos(num_id);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                Form1.pasarid = row.Cells[0].Value.ToString();
                Form1.pasarnombre = row.Cells[1].Value.ToString();
                Form1.pasarapellido = row.Cells[2].Value.ToString();
                Form1.pasarsexo = row.Cells[3].Value.ToString();
                Form1.pasarfecha = row.Cells[4].Value.ToString();
                Form1.pasarsalario = row.Cells[5].Value.ToString();
                Form1.pasarestatus = row.Cells[6].Value.ToString();
                Form1.pasarcedula = row.Cells[8].Value.ToString();

                Form1 F1 = new Form1();
                F1.Show();
                                
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
                     

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

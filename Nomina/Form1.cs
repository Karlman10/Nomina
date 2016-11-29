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
using System.Configuration;

namespace Nomina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string pasarnombre;
        public static string pasarapellido;
        public static string pasarsexo;
        public static string pasarfecha;
        public static string pasarsalario;
        public static string pasarid;
        public static string pasarcedula;
        public static string pasarestatus;
        

     
        private void Form1_Load(object sender, EventArgs e)
        {
            txt_nombre.Text = pasarnombre;
            txt_apellido.Text = pasarapellido;
            cmb_sexo.SelectedText = pasarsexo;
            txt_fecha_nac.Text = pasarfecha;
            txt_salario.Text = pasarsalario;
            txt_cedula.Text = pasarcedula;
            cmb_estatus.Text = pasarestatus;
            


        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SqlConnection conexion = new SqlConnection(con);
            string sql = "UPDATE [dbo].[empleado] SET [nombre] = " + "'" + txt_nombre.Text + "'" + " ,[apellido] = " + "'" + txt_apellido.Text + "'" + " ,[sexo] = " + "'" + cmb_sexo.Text + "'" + " ,[fecha_nacimiento] = " + "'" + txt_fecha_nac.Text + "'" + " ,[salario] =" + "'" + txt_salario.Text + "'" + " ,[estatus] =" + "'" + cmb_estatus.Text + "'" + " ,[foto] =" + "NULL" + " ,[cedula] =" + "'" + txt_cedula.Text + "'" + " WHERE id =" + pasarid + ';'; 
            try
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand(sql, conexion);
                int res = cmd.ExecuteNonQuery();
                if (res >= 1)
                {
                    label1.Text = "Data guardada!";
                }
            }
            catch (Exception x)
            {

                label1.Text = x.Message.ToString();
            }
            finally
            {
                conexion.Close();
            }


        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SqlConnection conexion = new SqlConnection(con);
            string sql = " INSERT INTO [dbo].[empleado] ([nombre] ,[apellido] ,[sexo] ,[fecha_nacimiento] ,[salario] ,[estatus] ,[foto] ,[cedula]) VALUES ('" + txt_nombre.Text + "', '" + txt_apellido.Text + "', '" + cmb_sexo.Text + "', '" + txt_fecha_nac.Text + "', '" + txt_salario.Text + "', '" + cmb_estatus.Text + "', NULL, '" + txt_cedula.Text + "' )";

            try
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand(sql, conexion);
                int res = cmd.ExecuteNonQuery();
                if (res >= 1)
                {
                    label1.Text = "Data guardada!";
                }
            }
            catch (Exception x)
            {

                label1.Text = x.Message.ToString();
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_fecha_nac.Clear();
            txt_salario.Clear();
            txt_cedula.Clear();
            
        }
    }
}

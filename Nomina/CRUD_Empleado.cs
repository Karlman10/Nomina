using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;
using System.IO;

namespace Nomina
{
    public partial class CRUD_Empleado : Form
    {
        public CRUD_Empleado()
        {
            InitializeComponent();
        }
        
        // Definir variables públicas para transferir datos entre formularios
        public static string pasarnombre;
        public static string pasarapellido;
        public static string pasarsexo;
        public static string pasarfecha;
        public static string pasarsalario;
        public static string pasarid;
        public static string pasarcedula;
        public static string pasarestatus;
        string fotos = "";
        SQLiteCommand comando;

     
        private void Form1_Load(object sender, EventArgs e)
        {
            // Igualar los textbox con variables públicas para presentar los datos transferidos
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
            // Crear conexion para actualizar los datos de la tabla empleado
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);

            // Definir el comando sql para actualizar el dato seleccionado
            string sql = "UPDATE [empleado] SET [nombre] = " + "'" + txt_nombre.Text + "'" + " ,[apellido] = " + "'" + txt_apellido.Text + "'" + " ,[sexo] = " + "'" + cmb_sexo.Text + "'" + " ,[fecha_nacimiento] = " + "'" + txt_fecha_nac.Text + "'" + " ,[salario] =" + "'" + txt_salario.Text + "'" + " ,[estatus] =" + "'" + cmb_estatus.Text + "'" + " ,[cedula] =" + "'" + txt_cedula.Text + "'" + " WHERE id_empleado =" + pasarid + ';';


            // (Try-Catch) Manejador de errores
            try
            {
                // Abrir conexion para actualizar los datos de la tabla empleado
                conexion.Open();

                // Definir comando para la conexion
                SQLiteCommand cmd = new SQLiteCommand(sql, conexion);


                // Verificar que el comando se ejecutó exitosamente
                int res = cmd.ExecuteNonQuery();
                if (res >= 1)
                {
                    // Para mostrar mensaje en caso de acierto o error
                    MessageBox.Show("Data actualizada!");
                }
            }
            catch (Exception x)
            {

                // Para mostrar mensaje en caso de acierto o error
                MessageBox.Show(x.Message.ToString());
            }
            finally
            {
                // Cerrar conexion
                conexion.Close();
            }


        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            // Crear conexion para insertar los datos de la tabla empleado
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);
            string sql = " INSERT INTO [empleado] ([nombre] ,[apellido] ,[sexo] ,[fecha_nacimiento] ,[salario] ,[estatus] ,[foto] ,[cedula]) VALUES ('" + txt_nombre.Text + "', '" + txt_apellido.Text + "', '" + cmb_sexo.Text + "', '" + txt_fecha_nac.Text + "', '" + txt_salario.Text + "', '" + cmb_estatus.Text + "', NULL, '" + txt_cedula.Text + "' )";

            // (Try-Catch) Manejador de errores
            try
            {
                // Abrir conexion para insertar los datos de la tabla empleado
                conexion.Open();

                // Definir comando para la conexion
                SQLiteCommand cmd = new SQLiteCommand(sql, conexion);


                // Verificar que el comando se ejecutó exitosamente
                int res = cmd.ExecuteNonQuery();
                if (res >= 1)
                {
                    // Para mostrar mensaje en caso de acierto o error
                    MessageBox.Show("Data guardada!");
                }
            }
            catch (Exception x)
            {

                // Para mostrar mensaje en caso de acierto o error
                MessageBox.Show(x.Message.ToString());
            }
            finally
            {
                // Cerrar conexion
                conexion.Close();
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            // Limpiar los textbox
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_fecha_nac.Clear();
            txt_salario.Clear();
            txt_cedula.Clear();
            
        }

        private void pic_foto_DoubleClick(object sender, EventArgs e)
        {
            // Seleccionador de archivo con filtro de extensiones 
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png| ALL Files (*.*)|*.*";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                fotos = openfile.FileName.ToString();
                pic_foto.ImageLocation = fotos;
            }
        }

        private void btn_salvar_foto_Click(object sender, EventArgs e)
        {

            // Verificar que el textbox no este vacio
            if (fotos != "") {

                // Crear conexion para insertar los datos de la tabla empleado
                string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
                SQLiteConnection conexion = new SQLiteConnection(con);

            // Crear arreglo tipo byte para almacenar la foto
            byte[] imagen = null;
            FileStream fs = new FileStream(fotos, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imagen = br.ReadBytes((int)fs.Length);
            
            // (Try-Catch) Manejador de errores
            try
            {
                // Abrir conexion para actualizar los datos de la tabla
                conexion.Open();

                // Crear conexion para actualizar la foto en la tabla empleado
                string sql = "UPDATE [empleado] SET foto = @imagen where id= " + pasarid;
                SQLiteCommand cmd = new SQLiteCommand(sql, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@imagen", imagen));

                // Verificar que el comando se ejecutó exitosamente
                int res = cmd.ExecuteNonQuery();
                if (res >= 1)
                {
                    // Para mostrar mensaje en caso de acierto o error
                    MessageBox.Show("Data actualizada!");
                }
            }
            catch (Exception x)
            {
                    // Para mostrar mensaje en caso de acierto o error
                    MessageBox.Show(x.Message.ToString());
            }
            finally
            {
                    // Cerrar conexion
                    conexion.Close();
                }

            }

            else
            {
                return;
            }


        }

       
        private void btn_eliminar_usuario_Click(object sender, EventArgs e)
        {
            // Verificar que el la variable no sea null
            if (pasarid != null)
            {
                // Crear conexion para eliminar el dato seleccionado
                string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
                SQLiteConnection conexion = new SQLiteConnection(con);

                // Definir el comando sql para eliminar el dato seleccionado
                string sql = "DELETE from empleado WHERE id_empleado =" + pasarid + ';';
                try
                {
                    // Abrir conexion para eliminar el dato seleccionado
                    conexion.Open();

                    SQLiteCommand cmd = new SQLiteCommand(sql, conexion);

                    // Verificar que el comando se ejecutó exitosamente
                    int res = cmd.ExecuteNonQuery();
                    if (res >= 1)
                    {
                        // Para mostrar mensaje en caso de acierto o error
                        MessageBox.Show("Data eliminada!");
                    }
                }
                catch (Exception x)
                {

                    // Para mostrar mensaje en caso de acierto o error
                    MessageBox.Show(x.Message.ToString());
                }
                finally
                {
                    // Cerrar conexion
                    conexion.Close();
                }
            }

            else
            {
                return;
            }
        }
    }
}

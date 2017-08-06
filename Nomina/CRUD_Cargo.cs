using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SQLite;

namespace Nomina
{
    public partial class CRUD_Cargo : Form
    {
        public CRUD_Cargo()
        {
            InitializeComponent();
        }

        private void CRUD_Cargo_Load(object sender, EventArgs e)
        {

            // Crear conexion para cargar los datos de la tabla cargo
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);
            DataSet ds = new DataSet();
            string sql = "select * from cargo";

            // (Try-Catch) Manejador de errores
            try
            {
                // Abrir conexion para cargar los datos de la tabla cargo
                conexion.Open();
                
                // Definir y cargar datos vía el adapter
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conexion);
                adapter.Fill(ds, "cargo");

                // Generar columnas y cargar datos en el datagridview
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "cargo";

                // Cerrar conexion
                conexion.Close();
            }
            catch (Exception ex)
            {
                // Para mostrar mensaje en caso de acierto o error
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                // Cerrar conexion
                conexion.Close();
            }


        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el datagridview contenga datos
            if (e.RowIndex >= 0)
            {
                // Definir la filas del datagridview
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                // Asociar los textboxs a las columnas del datagridview
                txt_ID_Cargo.Text = row.Cells[0].Value.ToString();
                txt_nombre_cargo.Text = row.Cells[1].Value.ToString();

            }
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            // Crear conexion para insertar los datos a la tabla cargo
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);
            string sql = " INSERT INTO [cargo] ([posicion] ) VALUES ( '"+ txt_nombre_cargo.Text +"') ";

            // (Try-Catch) Manejador de errores
            try
            {
                // Abrir conexion para insertar los datos de la tabla cargo
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear conexion para actualizar los datos a la tabla cargo
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);
            string sql = " UPDATE[cargo] SET[posicion] = " + "'" + txt_nombre_cargo.Text + "'" + "  WHERE id_cargo = " + txt_ID_Cargo.Text ;

            // (Try-Catch) Manejador de errores
            try
            {
                // Abrir conexion para actualizar los datos de la tabla cargo
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Verificar que el textbox no sea null
            if (txt_ID_Cargo.Text != null)
            {

                // Crear conexion para eliminar los datos de la tabla cargo
                string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
                SQLiteConnection conexion = new SQLiteConnection(con);

                // Definir el comando sql para eliminar el dato seleccionado
                string sql = "DELETE from cargo WHERE id_cargo =" + txt_ID_Cargo.Text + ';';



                // (Try-Catch) Manejador de errores
                try
                {
                    // Abrir conexion para insertar los datos de la tabla cargo
                    conexion.Open();

                    // Definir comando para la conexion
                    SQLiteCommand cmd = new SQLiteCommand(sql, conexion);
                    
                    // Verificar que el comando se ejecutó exitosamente
                    int res = cmd.ExecuteNonQuery();
                    if (res >= 1)
                    {
                        // Para mostrar mensaje en caso de acierto o error
                        MessageBox.Show ("Data eliminada!");
                    }
                }
                catch (Exception x)
                {

                    // Para mostrar mensaje en caso de acierto o error
                    MessageBox.Show (x.Message.ToString());
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

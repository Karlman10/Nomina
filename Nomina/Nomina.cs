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

namespace Nomina
{
    public partial class Nomina : Form
    {
        public Nomina()
        {
            InitializeComponent();
        }

        private void Nomina_Load(object sender, EventArgs e)
        {
            // Crear conexion para actualizar los datos a la tabla detallenomina
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);
            DataSet ds = new DataSet();
            string sql = "select * from detallenomina";

            // (Try-Catch) Manejador de errores
            try
            {
                // Abrir conexion para cargar los datos de la tabla detallenomina
                conexion.Open();


                // Definir y cargar datos vía el adapter
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conexion);
                adapter.Fill(ds, "detallenomina");

                // Generar columnas y cargar datos en el datagridview
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "detallenomina";

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
    }
}

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
    public partial class Busqueda : Form
    {
        public Busqueda()
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

            // Crear conexion para cargar los datos de la tabla empleado
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);
            DataSet ds = new DataSet();
            string sql = "select * from empleado" + filtro;

            try
            {
                // Abrir conexion para insertar los datos en el datagridview
                conexion.Open();

                // Definir y cargar datos vía el adapter
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conexion);
                adapter.Fill(ds, "empleado");

                // Generar columnas y cargar datos en el datagridview
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "empleado";

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

        // Verificar el boton seleccionado para elegir el filtro a utilizar
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (rad_Id.Checked)
            {
                filtro = "id_empleado=";
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

        // Función para cargar filtro (coincidencias exactas) seleccionado vía el radio buttom
        void carga_filtro ()
        {
            string texto = textBox1.Text.ToString();
            string num_id = " where " + filtro + "'" + texto + "'" + ";";
            carga_datos(num_id);
        }

        // Función para cargar filtro (tipo LIKE) seleccionado vía el radio buttom
        void carga_filtro2()
        {
            string texto = textBox1.Text.ToString();
            string num_id = " where " + filtro + "'%" + texto + "%'" + ";";
            carga_datos(num_id);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que las filas del datagridview sea diferente de 0
            if (e.RowIndex >= 0)
            {

                // Definir la filas del datagridview
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                // Asociar las variables a las columnas del datagridview
                CRUD_Empleado.pasarid = row.Cells[0].Value.ToString();
                CRUD_Empleado.pasarnombre = row.Cells[1].Value.ToString();
                CRUD_Empleado.pasarapellido = row.Cells[2].Value.ToString();
                CRUD_Empleado.pasarsexo = row.Cells[3].Value.ToString();
                CRUD_Empleado.pasarfecha = row.Cells[4].Value.ToString();
                CRUD_Empleado.pasarsalario = row.Cells[5].Value.ToString();
                CRUD_Empleado.pasarestatus = row.Cells[6].Value.ToString();
                CRUD_Empleado.pasarcedula = row.Cells[7].Value.ToString();

                // Mostrar formulario
                CRUD_Empleado F1 = new CRUD_Empleado();
                F1.Show();

                                                
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {

            // Mostrar formulario
            CRUD_Empleado F1 = new CRUD_Empleado();
            F1.Show();
                     

        }

        private void btn_gen_nomina_Click(object sender, EventArgs e)
        {


            // Definir comandos sql para insertar y actualizar los datos seleccionados
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);
            string sql = " INSERT INTO detallenomina (id_empleado) SELECT id_empleado from empleado;";
            string sql1 = " update detallenomina set isr = (SELECT salario * 0.12 FROM empleado where empleado.id_empleado = detallenomina.id_empleado);";
            string sql2 = " update detallenomina set deduccion_ss = (SELECT salario * 0.04 FROM empleado where empleado.id_empleado = detallenomina.id_empleado);";
            string sql3 = " update detallenomina set otros = (SELECT salario * 0.02 FROM empleado where empleado.id_empleado = detallenomina.id_empleado);";
            string sql4 = " update detallenomina set total_deducciones = (SELECT isr + deduccion_ss + otros FROM empleado where empleado.id_empleado = detallenomina.id_empleado);";
            string sql5 = " update detallenomina set sueldo_neto = (SELECT salario - total_deducciones FROM empleado where empleado.id_empleado = detallenomina.id_empleado);";

            // (Try-Catch) Manejador de errores
            try
            {
                // Definir comandos para las conexiones
                conexion.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conexion);
                SQLiteCommand cmd1 = new SQLiteCommand(sql1, conexion);
                SQLiteCommand cmd2 = new SQLiteCommand(sql2, conexion);
                SQLiteCommand cmd3 = new SQLiteCommand(sql3, conexion);
                SQLiteCommand cmd4 = new SQLiteCommand(sql4, conexion);
                SQLiteCommand cmd5 = new SQLiteCommand(sql5, conexion);

                // Verificar que los comandos se ejecutaron exitosamente
                int res = cmd.ExecuteNonQuery();
                int res1 = cmd1.ExecuteNonQuery();
                int res2 = cmd2.ExecuteNonQuery();
                int res3 = cmd3.ExecuteNonQuery();
                int res4 = cmd4.ExecuteNonQuery();
                int res5 = cmd5.ExecuteNonQuery();
                if (res >= 1)

                {
                    MessageBox.Show("Data guardada!");
                }

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

            // Mostrar formulario de Nomina
            Nomina Nom = new Nomina();
            Nom.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mostrar formulario
            CRUD_Cargo F1 = new CRUD_Cargo();
            F1.Show();
        }
    }
}

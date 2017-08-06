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
    public partial class Compania_del_Caribe : Form
    {
        public Compania_del_Caribe()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Mostrar formulario 
            CRUD_Empleado CEmpleado = new CRUD_Empleado();
            CEmpleado.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Crear conexion para actualizar los datos de la tabla empleado
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);

            // Definir comandos sql para insertar y actualizar los datos seleccionados
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

                    // Mostrar formulario de Nomina
                    Nomina Nom = new Nomina();
                    Nom.Show();

                    // Para mostrar mensaje en caso de acierto o error
                    MessageBox.Show ("Nómina Generada");
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
                       

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Mostrar formulario
            CRUD_Cargo CCargo = new CRUD_Cargo();
            CCargo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mostrar formulario
            Busqueda FBus = new Busqueda();
            FBus.Show();
        }
    }
}
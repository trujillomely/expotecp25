using IBM.Data.DB2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorAdmin
{
    public partial class frmespecialidad : Form
    {
        public frmespecialidad()
        {
            InitializeComponent();
        }

        public event EventHandler EspecialidadesActualizadas;

       
        private void btn_Click(object sender, EventArgs e)
        {
            string miConexion = "DATABASE = EXPOTEC1"; //CADENA DE CONEXION
            using (DB2Connection connection = new DB2Connection(miConexion))
            {
                try
                {


                    connection.Open();
                    string Sqlinsert = "INSERT INTO Especialidad(nombre)" + "VALUES(@NOMBRE)";
                    DB2Command cmd = new DB2Command(Sqlinsert, connection);
                    cmd.Parameters.Add("@NOMBRE", DB2Type.VarChar).Value = txtnombre.Text;

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha guardado su registro", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        EspecialidadesActualizadas?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("ERROR- No fue posible su registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex) //Manejo de excepciones en caso de error
                {
                    MessageBox.Show("ERROR EN EL SISTEMA" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}


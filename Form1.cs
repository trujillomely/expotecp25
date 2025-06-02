using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2;//Libreria de DB2


namespace DoctorAdmin
{
    public partial class Form1 : Form
    {
        // Cadena de conexión a DB2

        public Form1()
        {
            InitializeComponent();
            // Suscribirse al evento EspecialidadesActualizadas del formulario frmespecialidad
            frmespecialidad formAgregarEspecialidad = new frmespecialidad();
            formAgregarEspecialidad.EspecialidadesActualizadas += ActualizarComboBoxEspecialidades;
        }

        // Evento para cargar las especialidades al ComboBox
        private void ActualizarComboBoxEspecialidades(object sender, EventArgs e)
        {
            CargarEspecialidades();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        // Método para cargar las especialidades desde la base de datos
        private void CargarEspecialidades()
        {
            try
            {
                string miConexion = "DATABASE = EXPOTEC1";
                using (DB2Connection connection = new DB2Connection(miConexion))
                {
                    connection.Open();
                    string sql = "SELECT id, nombre FROM Especialidad";
                    DB2DataAdapter adapter = new DB2DataAdapter(sql, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    CMBESPECIALIDAD.DataSource = dt;
                    CMBESPECIALIDAD.DisplayMember = "nombre";
                    CMBESPECIALIDAD.ValueMember = "id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las especialidades médicas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Método para cerrar el formulario


        // Permitir que una ventana personalizada de Windows Forms pueda ser arrastrada al hacer clic
        private void FrmDoctor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            frmespecialidad form2 = new frmespecialidad();
            form2.EspecialidadesActualizadas += ActualizarComboBoxEspecialidades;
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarEspecialidades();

        }

        private void btnenviar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string miConexion = "DATABASE = EXPOTEC1";
                using (DB2Connection connection = new DB2Connection(miConexion))
                {
                    connection.Open();
                    string Sqlinsert = "INSERT INTO DOCTOR(dpi, nombres, apellidos, email, telefono, Especialidad) " +
                                       "VALUES (@DPI, @NOMBRE, @APELLIDO, @CORREO, @TELEFONO, @ESPECIALIDAD)";
                    DB2Command cmd = new DB2Command(Sqlinsert, connection);
                    cmd.Parameters.Add("@DPI", DB2Type.VarChar).Value = txtDpi.Text;
                    cmd.Parameters.Add("@NOMBRE", DB2Type.VarChar).Value = txtNombre.Text;
                    cmd.Parameters.Add("@APELLIDO", DB2Type.VarChar).Value = txtApellido.Text;
                    cmd.Parameters.Add("@CORREO", DB2Type.VarChar).Value = txtCorreo.Text;
                    cmd.Parameters.Add("@TELEFONO", DB2Type.VarChar).Value = txtTelefono.Text;
                    cmd.Parameters.Add("@ESPECIALIDAD", DB2Type.Integer).Value = CMBESPECIALIDAD.SelectedValue;

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha guardado su registro", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("ERROR - No fue posible su registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR EN EL SISTEMA: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
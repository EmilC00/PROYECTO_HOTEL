using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROYECTO_HOTEL
{
    public partial class LoginForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //Validación de espacios vacios en el Usuario y la contraseña
            if (txt_usuario.Text == "")
            {
                errorProvider1.SetError(txt_usuario, "Ingrese el usuario");
                txt_usuario.Focus();
                return;
            }
            errorProvider1.SetError(txt_usuario, "");

            if (txt_contraseña.Text == "")
            {
                errorProvider1.SetError(txt_contraseña, "Ingrese la contraseña");
                txt_contraseña.Focus();
                return;
            }
            errorProvider1.SetError(txt_contraseña, "");

            //Conectar a la base de datos
            string CADENA = @"Data source=DESKTOP-IGO8Q3K\MSSQLSERVER2; Initial Catalog=Proyecto_Hotel; User ID=sa; Password=1mnbvcxz1";
            bool esUsuarioValido = false;
            using (SqlConnection _conexion = new SqlConnection(CADENA))
            {
                _conexion.Open();

                string consulta = "SELECT 1 FROM USUARIOS WHERE CODIGO = '" + txt_usuario.Text + "' AND CLAVE = '" + txt_contraseña.Text + "';";

                using (SqlCommand comando = new SqlCommand(consulta, _conexion))
                {
                    esUsuarioValido = Convert.ToBoolean(comando.ExecuteScalar());
                }
            }

            if (esUsuarioValido)
            {

                Principal_Form formulario = new Principal_Form();
                this.Hide();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Usuario ó contraseña Invalidos");
            }

        }

        

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Catering;
using Entity_Catering;

namespace Servicio_Catering.UIAdminstrador
{
    public partial class UIAgregarUsuario : Form
    {

        UsuarioBLL _usuarioBLL;
        Usuario _usuarioAux;
        public UIAgregarUsuario()
        {
            InitializeComponent();
            _usuarioBLL = new UsuarioBLL();
            _usuarioAux = new Usuario();
        }

        private void UIAgregarUsuario_Load(object sender, EventArgs e)
        {
         


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            
            string nombre;
            string apellido;
            string dni;
            string domicilio;
            string telefono;
            string perfil;
            string email;
            string clave;
            DateTime fechaCreacion;

            nombre = tboxNombre.Text;
            apellido = tboxApellido.Text;
            dni = tboxDni.Text;
            domicilio = tboxDomicilio.Text;
            telefono = tboxTelefono.Text;
            perfil = cboxPerfil.SelectedItem as string;
            email = tboxEmail.Text;
            clave = tboxClave.Text;
            fechaCreacion = DateTime.Now.Date;

            try
            {


                if (nombre.Length > 0 && apellido.Length > 0 && dni.Length > 0 && domicilio.Length > 0 && telefono.Length > 0 && perfil.Length > 0 && email.Length > 0 && clave.Length > 0)
                {
                    if (_usuarioBLL.CrearUsuario(nombre, apellido, dni, domicilio, telefono, perfil, email, clave, fechaCreacion))
                    {
                        MessageBox.Show("Usuario creado con exito.", "Confirmación", MessageBoxButtons.OK);
                        tboxNombre.Text = "";
                        tboxApellido.Text = "";
                        tboxDni.Text = "";
                        tboxTelefono.Text = "";
                        tboxEmail.Text = "";
                        tboxClave.Text = "";
                        tboxDomicilio.Text = "";
                        cboxPerfil.Text = "";
                        this.Close();
                        

                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al crear el usuario. Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }


        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Borrará todos los datos ingresados, ¿desea continuar?", "Advertencia",MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {

                tboxNombre.Text = "";
                tboxApellido.Text = "";
                tboxDni.Text = "";
                tboxTelefono.Text = "";
                tboxEmail.Text = "";
                tboxClave.Text = "";
                tboxDomicilio.Text = "";
                cboxPerfil.Text = "";
            }



        }
    }
}

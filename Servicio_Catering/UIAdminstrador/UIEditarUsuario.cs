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

    public partial class UIEditarUsuario : Form
    {
        private Usuario userAux;
        private UsuarioBLL _usuarioBLL;
        public UIEditarUsuario()
        {

        }
        public UIEditarUsuario(Usuario usuarioAux)
        {
            InitializeComponent();
            _usuarioBLL = new UsuarioBLL();

            userAux = usuarioAux;
            tboxNombre.Text = usuarioAux.Nombre;
            tboxApellido.Text = usuarioAux.Apellido;
            tboxDni.Text = usuarioAux.DNI;
            tboxDomicilio.Text = usuarioAux.Domicilio;
            tboxTelefono.Text = usuarioAux.Telefono;
            tboxEmail.Text = usuarioAux.Email;
            tboxClave.Text = usuarioAux.Clave;
            cboxPerfil.Text = usuarioAux.Perfil;
        }

        private void UIEditarUsuario_Load(object sender, EventArgs e)
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
            int id;

            nombre = tboxNombre.Text;
            apellido = tboxApellido.Text;
            dni = tboxDni.Text;
            domicilio = tboxDomicilio.Text;
            telefono = tboxTelefono.Text;
            perfil = cboxPerfil.SelectedItem as string;
            email = tboxEmail.Text;
            clave = tboxClave.Text;
            id = userAux.IdUsuario;

            try
            {

                DialogResult resultado = MessageBox.Show("¿Desea guardar los cambios en el usuario?", "ADVERTENCIA",MessageBoxButtons.OKCancel);

                if (nombre.Length > 0 && apellido.Length > 0 && dni.Length > 0 && domicilio.Length > 0 && telefono.Length > 0 && perfil.Length > 0 && email.Length > 0 && clave.Length > 0)
                {
                   if(resultado == DialogResult.OK)
                    {

                        if (_usuarioBLL.EditarUsuario(nombre, apellido, dni, domicilio, telefono, perfil, email, clave, id))
                        {
                            MessageBox.Show("Usuario editado con exito.", "Confirmación", MessageBoxButtons.OK);
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
                            MessageBox.Show("Hubo un problema al editar el usuario. Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK);


                        }
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
            this.Close();
        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {

            string nombre;
            string apellido;
            string dni;
            string domicilio;
            string telefono;
            string perfil;
            string email;
            string clave;


            nombre = tboxNombre.Text;
            apellido = tboxApellido.Text;
            dni = tboxDni.Text;
            domicilio = tboxDomicilio.Text;
            telefono = tboxTelefono.Text;
            perfil = cboxPerfil.SelectedItem as string;
            email = tboxEmail.Text;
            clave = tboxClave.Text;



          

            try
            {

                DialogResult resultado = MessageBox.Show("ADVERTENCIA: ¿Desea dar de baja el usuario actual?", "ADVERTENCIA", MessageBoxButtons.OKCancel);
                if(resultado == DialogResult.OK)
                {

                    if(_usuarioBLL.BajaUsuario(nombre, apellido, dni, domicilio, telefono, perfil, email, clave))
                    {
                        MessageBox.Show("El usuario fue dado de baja correctamente.", "Confirmacón", MessageBoxButtons.OK);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Hubo un problema al intentar dar de baja el usuario.","Advertencia", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
    }
}

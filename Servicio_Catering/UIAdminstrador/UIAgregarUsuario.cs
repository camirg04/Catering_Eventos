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
            warningNombre.Text = "";


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

            nombre = lblNombre.Text;
            apellido = lblApellido.Text;
            dni = lblDni.Text;
            domicilio = lblDomicilio.Text;
            telefono = lblTelefono.Text;
            perfil = lblPerfil.Text;
            email = lblEmail.Text;
            clave = lblClave.Text;
            fechaCreacion = DateTime.Now.Date;

            _usuarioBLL.CrearUsuario(nombre,apellido,dni,domicilio,telefono,perfil,email,clave,fechaCreacion);
                  


        }
    }
}

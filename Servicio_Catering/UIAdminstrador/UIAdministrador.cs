using System;
using System.CodeDom;
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
using NLog;

namespace Servicio_Catering.UIAdminstrador
{
    public partial class UIAdministrador : Form
    {
        private readonly UsuarioBLL _usuarioBLL;
        private Usuario _usuario;
        public UIAdministrador(Usuario user)
        {
            InitializeComponent();
            _usuarioBLL = new UsuarioBLL();
            _usuario = user;
        }

        public string darBienvenida(string nombre)
        {
            return "¡Bienvenido/a " + nombre + "!";
        }

        private void btnTodoEmpleados_Click(object sender, EventArgs e)
        {
            try
            {

                List<Usuario> listAux = _usuarioBLL.ListarActivos();
                dgvVisualizaUsuarios.DataSource = listAux;
                dgvVisualizaUsuarios.Columns["mail"].Visible = false;
                dgvVisualizaUsuarios.Columns["fechaBajaUsuario"].Visible = false;
                dgvVisualizaUsuarios.Columns["idUsuario"].HeaderText = "ID";
            }
            catch (Exception ex)
            {

           
                MessageBox.Show(ex.Message);

             
            }

         
        }

        private void UIAdministrador_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = darBienvenida(_usuario.Nombre);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tboxInDNI.Text.Length > 0 || tboxInApellido.Text.Length > 0)
                {

                    List<Usuario> listAux = new List<Usuario>();
                    string auxDni, auxApellido;


                    auxDni = tboxInDNI.Text;
                    auxApellido = tboxInApellido.Text;

                    listAux = _usuarioBLL.BuscarActivos(auxDni, auxApellido);

                    if (listAux.Count != 0)
                    {

                        dgvVisualizaUsuarios.DataSource = listAux;
                        tboxInDNI.Text = "";
                        tboxInApellido.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("No hay coincidencias con los criterios de busqueda", "Advertencia", MessageBoxButtons.OK);
                        tboxInDNI.Text = "";
                        tboxInApellido.Text = "";
                    }


                }
                else
                {
                    MessageBox.Show("Antes de presionar buscar, ingrese un DNI o un apellido.", "ADVERTENCIA", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            UIAgregarUsuario ventanaAgregarUsuario = new UIAgregarUsuario();
            ventanaAgregarUsuario.ShowDialog();
        }
    }
}

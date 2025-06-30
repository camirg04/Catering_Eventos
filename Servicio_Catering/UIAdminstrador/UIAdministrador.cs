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
        private readonly Usuario _usuarioAux;
        public UIAdministrador(Usuario user)
        {
            InitializeComponent();
            _usuarioBLL = new UsuarioBLL();
            _usuario = user;
            _usuarioAux = new Usuario();
        }

        public string darBienvenida(string nombre)
        {
            return "¡Bienvenido/a " + nombre + "!";
        }

        //el boton deberia llamarse btnTodoUsuarios.
        private void btnTodoEmpleados_Click(object sender, EventArgs e)
        {
            try
            {

                List<Usuario> listAux = _usuarioBLL.ListarActivos();
                dgvVisualizaUsuarios.DataSource = listAux;
                dgvVisualizaUsuarios.Columns["mail"].Visible = false;
                dgvVisualizaUsuarios.Columns["fechaBajaUsuario"].Visible = false;
                dgvVisualizaUsuarios.Columns["idUsuario"].HeaderText = "ID";
                btnEditarUsuario.Enabled = true;
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

        public void cerrarSesion()
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cerrarSesion();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
          //  string cadena;
            try
            {
                _usuarioAux.Nombre = dgvVisualizaUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                _usuarioAux.Apellido = dgvVisualizaUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
                _usuarioAux.Domicilio = dgvVisualizaUsuarios.CurrentRow.Cells["Domicilio"].Value.ToString();
                _usuarioAux.DNI = dgvVisualizaUsuarios.CurrentRow.Cells["DNI"].Value.ToString();
                _usuarioAux.Telefono = dgvVisualizaUsuarios.CurrentRow.Cells["Telefono"].Value.ToString();
                _usuarioAux.Perfil = dgvVisualizaUsuarios.CurrentRow.Cells["Perfil"].Value.ToString();
                _usuarioAux.Email = dgvVisualizaUsuarios.CurrentRow.Cells["Email"].Value.ToString();
                _usuarioAux.Clave = dgvVisualizaUsuarios.CurrentRow.Cells["Clave"].Value.ToString();
                _usuarioAux.IdUsuario = int.Parse(dgvVisualizaUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString());

                //        cadena = _usuarioAux.Nombre + "\n" + _usuarioAux.Apellido + "\n" + _usuarioAux.Domicilio + "\n" + _usuarioAux.DNI + "\n" + _usuarioAux.Telefono + "\n" + _usuarioAux.Perfil + "\n" + _usuarioAux.Email + "\n" + _usuarioAux.Clave;

                ;

                UIEditarUsuario ventanaEdicionUsuario = new UIEditarUsuario(_usuarioAux);
                ventanaEdicionUsuario.Show();

        


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }


            



        }
    }
}

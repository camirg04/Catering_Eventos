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

namespace Servicio_Catering
{
    public partial class UILogistica : Form, PerfilUsuario
    {
        private Usuario _usuario;
        public UILogistica(Usuario user)
        {
            InitializeComponent();
            _usuario = user;
        }


        public string darBienvenida(string nombre)
        {
            return "¡Bienvenido/a " + nombre + "!";
        }

        public void cerrarSesion()
        {
            this.Close();
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            cerrarSesion();
        }

        private void UILogistica_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = darBienvenida(_usuario.Nombre);
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}

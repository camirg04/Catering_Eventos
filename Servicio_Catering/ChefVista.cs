using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity_Catering;

namespace Servicio_Catering
{
    public partial class Administracion : Form
    {
        private Usuario _usuario;

        public Administracion(Usuario user)
        {
            InitializeComponent();
            _usuario = user;
 
            //tamaño mímimo de la ventana al inicializar componente
            this.MinimumSize = new Size(1000, 600);

            //para que el date time picker se vea como dd/mm/yyyy
            fechaDesdeEvento.Format = DateTimePickerFormat.Short;
            fechaHastaEvento.Format = DateTimePickerFormat.Short;

            this.Load += (sender, e) => MensajeBienvenida();
        }

        private void MensajeBienvenida()
        {
            lblBienvenida.Text = "¡Bienvenido/a " + _usuario.Nombre + "!";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Administracion_Load(object sender, EventArgs e)
        {

        }

        private void agregarPlato_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}

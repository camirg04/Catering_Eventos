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
using BLL_Catering;
using NLog;
using System.IO;

namespace Servicio_Catering
{
    public partial class Administracion : Form, PerfilUsuario
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly Usuario _usuario;
        private readonly HelperFront _helperFront;
        private readonly PlatoBLL _platoBLL;

        public Administracion(Usuario user)
        {
            InitializeComponent();
            _usuario = user;
            _helperFront = new HelperFront();
            _platoBLL = new PlatoBLL();
        }


        private void ObtenerPlatosFiltro()
        {
            try
            {
                string nombrePLato = txtNombre.Text;
                string tipoPlato = cbTipoPlato.Text;
                string activo = cbActivo.Text;
                List<Plato> platos = _platoBLL.BuscarPlatos(nombrePLato, tipoPlato, activo);
                dgvPlatos.DataSource = platos;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al buscar platos en UI");
                throw ex;
            }
        }

        private void verPlato_Click(object sender, EventArgs e)
        {
            Plato plato = (Plato)dgvPlatos.CurrentRow.DataBoundItem;

            PlatoDetalle platoDetalle = new PlatoDetalle(plato, "editar");
            platoDetalle.ShowDialog();
            ObtenerPlatosFiltro();
        }

        private void Administracion_Load(object sender, EventArgs e)
        {
            try
            {
                //tamaño mímimo de la ventana al inicializar componente
                this.MinimumSize = new Size(1000, 600);

                //para que el date time picker se vea como dd/mm/yyyy
                fechaDesdeEvento.Format = DateTimePickerFormat.Short;
                fechaHastaEvento.Format = DateTimePickerFormat.Short;

                lblBienvenida.Text = darBienvenida(_usuario.Nombre);
                dgvPlatos.ReadOnly = true;
                ObtenerPlatosFiltro();
                _helperFront.cargarComboTipoPlato(cbTipoPlato);
                _helperFront.cargarComboSiNo(cbActivo);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar la ventana de administración");
                MessageBox.Show("Error al cargar la ventana de administración");
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try {
                ObtenerPlatosFiltro();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al buscar platos en UI");
                MessageBox.Show("Error al buscar platos");
            }            
        }

        private void agregarPlato_Click(object sender, EventArgs e)
        {
            Plato plato = new Plato();
            PlatoDetalle platoDetalle = new PlatoDetalle(plato,"agregar");
            platoDetalle.ShowDialog();
            ObtenerPlatosFiltro();
        }


        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            cerrarSesion();
        }

        public string darBienvenida(string nombre)
        {
            return "¡Bienvenido/a " + nombre + "!";
        }

        public void cerrarSesion()
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

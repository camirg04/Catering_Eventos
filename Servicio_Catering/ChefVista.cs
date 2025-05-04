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

namespace Servicio_Catering
{
    public partial class Administracion : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private Usuario _usuario;
        private HelperFront _helperFront;
        private PlatoBLL _platoBLL;

        public Administracion(Usuario user)
        {
            InitializeComponent();
            _usuario = user;
            _helperFront = new HelperFront();
            _platoBLL = new PlatoBLL();
        }

        private void MensajeBienvenida()
        {
            lblBienvenida.Text = "¡Bienvenido/a " + _usuario.Nombre + "!";
        }

        private void ObtenerPlatosActivos()
        {
            try {
                List<Plato> platos = _platoBLL.BuscarPlatos(null, null, "Si");
                dgvPlatos.DataSource = platos;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al obtener los platos activos en UI");
                throw ex;
            }            
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

        private void verPlato_Click(object sender, EventArgs e)
        {
            Plato plato = (Plato)dgvPlatos.CurrentRow.DataBoundItem;

            PlatoDetalle platoDetalle = new PlatoDetalle(plato);
            platoDetalle.ShowDialog();
            ObtenerPlatosActivos();
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

                MensajeBienvenida();
                dgvPlatos.ReadOnly = true;
                ObtenerPlatosActivos();
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
                string nombrePLato = txtNombre.Text;
                string tipoPlato = cbTipoPlato.Text;
                string activo = cbActivo.Text;
                List<Plato> platos = _platoBLL.BuscarPlatos(nombrePLato, tipoPlato, activo);
                dgvPlatos.DataSource = platos;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al buscar platos en UI");
                MessageBox.Show("Error al buscar platos");
            }
            
        }
    }
}

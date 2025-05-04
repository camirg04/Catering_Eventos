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
using NLog;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Servicio_Catering
{
    public partial class PlatoDetalle : Form
    {
        private Plato _plato;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private HelperFront _helperFront;
        public PlatoDetalle(Plato plato)
        {
            _plato = plato;
            _helperFront = new HelperFront();
            InitializeComponent();
        }


        private void preseleccionarDatos() {
            txtNombrePlato.Text = _plato.Nombre;
            cbTipoPlato.SelectedIndex = cbTipoPlato.FindStringExact(_plato.TipoPlato);
        }

        private void preseleccionarActivoYBaja() {
            if (_plato.FechaBaja == null)
            {
                cbPlatoActivo.SelectedIndex = cbPlatoActivo.FindStringExact("Si");
                lbFechaBaja.Text = "-";
            }
            else
            {
                cbPlatoActivo.SelectedIndex = cbPlatoActivo.FindStringExact("No");
                lbFechaBaja.Text = _plato.FechaBaja.ToString();
            }
        }

        private void PlatoDetalle_Load(object sender, EventArgs e)
        {
            try {
                _helperFront.cargarComboTipoPlato(cbTipoPlato);
                _helperFront.cargarComboSiNo(cbPlatoActivo);
                preseleccionarDatos();
                preseleccionarActivoYBaja();
            }catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar los datos del plato en UI");
                MessageBox.Show("Error al cargar los datos del plato");

            }
        }
    }
}

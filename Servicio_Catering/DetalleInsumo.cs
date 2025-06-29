using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Catering;
using Entity_Catering;
using NLog;

namespace Servicio_Catering
{
    public partial class DetalleInsumo : Form
    {
        private string _modo;
        private Insumo _insumo;
        private readonly LogisticaBLL _logisticaBLL;
        private readonly HelperFront _helperFront;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public DetalleInsumo(Insumo insumo, string modo)
        {
            InitializeComponent();
            _logisticaBLL = new LogisticaBLL();
            _helperFront = new HelperFront();
            _modo = modo;
            _insumo = insumo;         
        }


        private void btnGuardarInsumo_Click(object sender, EventArgs e)
        {
            try
            {
                //validar datos obligatorios
                _logisticaBLL.ValidarDatosInsumo(tbNombreInsumo.Text, tbUnidadMedidaInsumo.Text, tbStockMinimoInsumo.Text, cbPerecederoInsumo.Text, cbActivoInsumo.Text);
                _insumo.Nombre = tbNombreInsumo.Text;
                _insumo.UnidadMedida = tbUnidadMedidaInsumo.Text;
                _insumo.StockMinimo = Decimal.Parse(tbStockMinimoInsumo.Text, new CultureInfo("es-ES"));
                _insumo.EsPerecedero = cbPerecederoInsumo.Text;
                if (cbActivoInsumo.Text == "Si")
                {
                    _insumo.FechaBaja = null;
                }
                else if (cbActivoInsumo.Text == "No")
                {
                    _insumo.FechaBaja = DateTime.Now;
                }

                bool exito = false;
                if (_modo != "editar")
                {
                    exito = _logisticaBLL.AgregarInsumo(_insumo);
                }
                else
                {
                    exito = _logisticaBLL.EditarInsumo(_insumo);
                }

                if (exito)
                {
                    MessageBox.Show("Insumo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetVisibilidadVer();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el insumo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el insumo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbActivoInsumo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbActivoInsumo.Text == "Si")
                {
                    lbFechaBajaInsumo.Text = "-";
                }
                else if (cbActivoInsumo.Text == "No")
                {
                    if (_insumo.FechaBaja == null)
                    {
                        lbFechaBajaInsumo.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        lbFechaBajaInsumo.Text = _insumo.FechaBaja.ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                MessageBox.Show("Error al cambiar el estado del insumo");
            }
        }

        private void preseleccionarActivoYBaja()
        {
            try
            {
                if (_insumo.FechaBaja == null)
                {
                    cbActivoInsumo.SelectedIndex = cbActivoInsumo.FindStringExact("Si");
                    lbFechaBajaInsumo.Text = "-";
                }
                else
                {
                    cbActivoInsumo.SelectedIndex = cbActivoInsumo.FindStringExact("No");
                    lbFechaBajaInsumo.Text = _insumo.FechaBaja.ToString();
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                MessageBox.Show("Error al preseleccionar el estado del insumo");
            }
        }

        private void DetalleInsumo_Load(object sender, EventArgs e)
        {
            _helperFront.cargarComboSiNo(cbPerecederoInsumo);
            _helperFront.cargarComboSiNo(cbActivoInsumo);
            CargarDatos();
            preseleccionarActivoYBaja();
        }

        
        private void SetVisibilidadEditar()
        {
            tbNombreInsumo.Enabled = true;
            tbUnidadMedidaInsumo.Enabled = true;
            tbStockMinimoInsumo.Enabled = true;
            cbPerecederoInsumo.Enabled = true;
            cbActivoInsumo.Enabled = true;
            btnGuardarInsumo.Visible = true;
            btnEditarInsumo.Visible = false;
        }

        private void SetVisibilidadVer()
        {
            tbNombreInsumo.Enabled = false;
            tbUnidadMedidaInsumo.Enabled = false;
            tbStockMinimoInsumo.Enabled = false;
            cbPerecederoInsumo.Enabled = false;
            cbActivoInsumo.Enabled = false;
            btnGuardarInsumo.Visible = false;
            btnEditarInsumo.Visible = true;
        }

        private void btnEditarInsumo_Click(object sender, EventArgs e)
        {
            SetVisibilidadEditar();
        }

        private void CargarDatos()
        {
            if(_modo == "editar")
            {
                tbNombreInsumo.Text = _insumo.Nombre;
                tbUnidadMedidaInsumo.Text = _insumo.UnidadMedida;
                tbStockMinimoInsumo.Text = _insumo.StockMinimo.ToString();
                cbPerecederoInsumo.SelectedIndex = cbPerecederoInsumo.FindStringExact(_insumo.EsPerecedero);
                SetVisibilidadVer();
            }
            else
            {
                SetVisibilidadEditar();
            }
        }
    }
}

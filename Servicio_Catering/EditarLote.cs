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
using DTO_Catering;
using Entity_Catering;
using NLog;

namespace Servicio_Catering
{
    public partial class EditarLote : Form
    {
        private LoteInsumoDTO _lote;
        private HelperFront _helperFront;
        private LogisticaBLL _logisticaBLL = new LogisticaBLL();
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();


        public EditarLote(LoteInsumoDTO lote)
        {
            InitializeComponent();
            _lote = lote;
            _helperFront = new HelperFront();
        }

        private void EditarLote_Load(object sender, EventArgs e)
        {
            tbLote.Enabled = false;
            tbCantidad.Enabled = false;
            tbCostoUnitario.Enabled = true;
            tbInsumo.Enabled = false;
            tbUnidadMedida.Enabled = false;
            tbLote.Text = _lote.IdLoteInsumo.ToString();
            tbInsumo.Text = _lote.NombreInsumo;
            tbCantidad.Text = _lote.Cantidad.ToString();
            tbCostoUnitario.Text = _lote.CostoUnitario.ToString();
            tbUnidadMedida.Text = _lote.UnidadMedida;
            dtVencimiento.Value = _lote.FechaIngreso;
  
        }


        private void btnGuardarMenu_Click(object sender, EventArgs e)
        {
            try
            {
                int exito = _logisticaBLL.ActualizarCostoFechaLote(_lote.IdLoteInsumo, tbCostoUnitario.Text, dtVencimiento.Value);
                if (exito > 0) {
                    MessageBox.Show("Lote de insumo actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch(ArgumentException ex)
            {
                logger.Error(ex, "Error de validación al guardar el lote de insumo");
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) {
                logger.Error(ex, "Error al guardar el lote de insumo");
                MessageBox.Show("Error al guardar el lote de insumo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

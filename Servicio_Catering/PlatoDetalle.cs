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
using DTO_Catering;
using System.IO;
using System.Globalization;
using BLL_Catering;

namespace Servicio_Catering
{
    public partial class PlatoDetalle : Form
    {
        private readonly Plato _plato;
        private BindingList<InsumoPlatoDTO> _listaInsumosPlato;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly HelperFront _helperFront;
        private readonly string _modo;
        private List<InsumoPlatoDTO> _insumosEliminar;
        private List<InsumoPlatoDTO> _insumosAgregar;
        private List<InsumoPlatoDTO> _insumosEditar;
        private List<Insumo> _insumos;

        public PlatoDetalle(Plato plato, string modo)
        {
            _plato = plato;
            _helperFront = new HelperFront();
            _modo = modo;
            _insumosEliminar = new List<InsumoPlatoDTO>();
            _insumosAgregar = new List<InsumoPlatoDTO>();
            _insumosEditar = new List<InsumoPlatoDTO>();
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
                getListaInsumos();
                _helperFront.cargarComboIsumos(cbIngredientes, _insumos);
                dgvIngredientes.ReadOnly = true;
               

                if (_modo == "agregar")
                {
                    //visibilidad de los botones al agregar
                    _listaInsumosPlato = new BindingList<InsumoPlatoDTO>();
                    visibilidadBotonesAgregarEditar();
                    lbFechaBaja.Text = "-";

                    _plato.ListaInsumos = new List<PlatoInsumo>();
                    dgvIngredientes.DataSource = _listaInsumosPlato;
                }
                else
                {
                    //visibilidad de los botones al ver detalle
                    visibilidadBotonesVer();
                    _listaInsumosPlato = InsumoPlatoDTO.mapPlatoInsumoListToInsumoPlatoDTOBindingList(_plato.ListaInsumos);
                    cargarInsumos();
                    preseleccionarDatos();
                    preseleccionarActivoYBaja();
                    
                }
            
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar los datos del plato en UI");
                MessageBox.Show("Error al cargar los datos del plato");

            }
        }

        private void cargarInsumos()
        {
            dgvIngredientes.DataSource = _listaInsumosPlato;
            dgvIngredientes.Columns["IdInsumo"].Visible = false;
            dgvIngredientes.Columns["IdInsumoPlato"].Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbPlatoActivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPlatoActivo.Text == "Si")
            {
                lbFechaBaja.Text = "-";
            }
            else if (cbPlatoActivo.Text == "No")
            {
                if (_plato.FechaBaja == null)
                {
                    lbFechaBaja.Text = DateTime.Now.ToString("dd/MM/yyyy");
                }
                else {
                    lbFechaBaja.Text = _plato.FechaBaja.ToString();
                }
                
            }
        }

        private void lbFechaBaja_Click(object sender, EventArgs e)
        {

        }

        private void verPlato_Click(object sender, EventArgs e)
        {

        }

        private void agregarPlato_Click(object sender, EventArgs e)
        {

        }

      

        private void txtNombrePlato_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditarPlato_Click(object sender, EventArgs e)
        {
            visibilidadBotonesAgregarEditar();

        }

        private void visibilidadBotonesAgregarEditar()
        {
            txtNombrePlato.Enabled = true;
            cbPlatoActivo.Enabled = true;
            cbTipoPlato.Enabled = true;
            btnEditarPlato.Visible = false;
            btnEliminarIngrediente.Visible = true;
            btnGuardar.Visible = true;
            lblCantidad.Visible = true;
            lblIngrediente.Visible = true;
            cbIngredientes.Visible = true;
            txtCantidad.Visible = true;
            btnEliminarIngrediente.Visible = true;
            btnAgregarIngrediente.Visible = true;
            btnEditarIngrediente.Visible = true;
        }

        private void visibilidadBotonesVer()
        {
            txtNombrePlato.Enabled = false;
            cbPlatoActivo.Enabled = false;
            cbTipoPlato.Enabled = false;
            btnEditarPlato.Visible = true;
            btnEliminarIngrediente.Visible = false;
            btnGuardar.Visible = false;

            lblCantidad.Visible = false;
            lblIngrediente.Visible = false;
            cbIngredientes.Visible = false;
            txtCantidad.Visible = false;
            btnEliminarIngrediente.Visible = false;
            btnAgregarIngrediente.Visible = false;
            btnEditarIngrediente.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarIngrediente_Click(object sender, EventArgs e)
        {
            bool esDecimal = _helperFront.esDecimal(txtCantidad.Text);
            if (!esDecimal)
            {
                MessageBox.Show("Formato numero incorrecto");
                return;
            }

            int idInsumo = (int)cbIngredientes.SelectedValue;
            foreach (InsumoPlatoDTO insumo in _listaInsumosPlato)
            {
                if (insumo.IdInsumo == idInsumo)
                {
                    MessageBox.Show("El insumo ya existe en el plato");
                    return;
                }
            }

            Insumo ins = _insumos.Find(_insumo=> _insumo.IdInsumo == idInsumo);
            InsumoPlatoDTO insumoPlato = new InsumoPlatoDTO(0, ins.IdInsumo, Decimal.Parse(txtCantidad.Text, new CultureInfo("es-ES")), ins.Nombre, ins.UnidadMedida);
            _listaInsumosPlato.Add(insumoPlato);
            _insumosAgregar.Add(insumoPlato);
        }

        private void eliminarPlato_Click(object sender, EventArgs e)
        {
            InsumoPlatoDTO insumo = (InsumoPlatoDTO)dgvIngredientes.CurrentRow.DataBoundItem;
            _insumosEliminar.Add(insumo);
            _listaInsumosPlato.Remove(insumo);
        }

        private void btnEditarIngrediente_Click(object sender, EventArgs e)
        {
            InsumoPlatoDTO insumoSeleccionado = (InsumoPlatoDTO)dgvIngredientes.CurrentRow.DataBoundItem;
            if(insumoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un insumo para editar");
                return;
            }

            bool esDecimal = _helperFront.esDecimal(txtCantidad.Text);
            if (!esDecimal)
            {
                MessageBox.Show("Formato numero incorrecto");
                return;
            }

            int idInsumo = (int)cbIngredientes.SelectedValue;
            int mismoInsumo = 0;
            foreach (InsumoPlatoDTO insumo in _listaInsumosPlato)
            {
                if (insumo.IdInsumo == idInsumo)
                {
                    mismoInsumo++;
                }
            }

            if (mismoInsumo > 1)
            {
                MessageBox.Show("No se puede duplicar el insumo en el plato");
                return;
            }

            Insumo ins = _insumos.Find(_insumo => _insumo.IdInsumo == idInsumo);
            insumoSeleccionado.CantidadNecesaria = Decimal.Parse(txtCantidad.Text, new CultureInfo("es-ES"));
            insumoSeleccionado.IdInsumo = ins.IdInsumo;
            insumoSeleccionado.NombreInsumo = ins.Nombre;
            insumoSeleccionado.UnidadMedida = ins.UnidadMedida;
            _insumosEditar.Add(insumoSeleccionado);
            dgvIngredientes.BindingContext[dgvIngredientes.DataSource].EndCurrentEdit();
        }

        public void getListaInsumos()
        {
            try
            {
                InsumoBLL insumoBLL = new InsumoBLL();
                _insumos = insumoBLL.ObtenerInsumosActivos();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al obtener la lista de insumos");
                MessageBox.Show("Error al obtener la lista de insumos");
            }
        }

        private void dgvIngredientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            return;
        }

        private void dgvIngredientes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                InsumoPlatoDTO insumoSeleccionado = (InsumoPlatoDTO)dgvIngredientes.CurrentRow.DataBoundItem;
                Insumo ins = _insumos.Find(_insumo => _insumo.IdInsumo == insumoSeleccionado.IdInsumo);
                cbIngredientes.SelectedValue = ins.IdInsumo;
                txtCantidad.Text = insumoSeleccionado.CantidadNecesaria.ToString();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al seleccionar insumo en la grilla");
            }
        }
    }
}

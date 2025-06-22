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
using DTO_Catering;
using Entity_Catering;
using NLog;

namespace Servicio_Catering
{
    public partial class EditarPlato : Form
    {
        private readonly Plato _plato;
        private readonly ChefBLL _chefBLL;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly HelperFront _helperFront;
        private string _modo;
        private BindingList<InsumoPlatoDTO> _listaInsumosPlato;
        private List<Insumo> _insumos;

        public EditarPlato(Plato plato, string modo)
        {
            _plato = plato;
            _helperFront = new HelperFront();
            _modo = modo;
            _chefBLL = new ChefBLL();
            InitializeComponent();
        }

        private void preseleccionarDatos()
        {
            txtNombrePlato.Text = _plato.Nombre;
            cbTipoPlato.SelectedIndex = cbTipoPlato.FindStringExact(_plato.TipoPlato);
        }

        private void preseleccionarActivoYBaja()
        {
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

        private void EditarPlato_Load(object sender, EventArgs e)
        {
            try
            {
                _helperFront.cargarComboTipoPlato(cbTipoPlato);
                _helperFront.cargarComboSiNo(cbPlatoActivo);
                getListaInsumos();
                _helperFront.cargarComboIsumos(cbIngredientes, _insumos);
                dgvIngredientes.ReadOnly = true;


                if (_modo == "agregar")
                {
                    //visibilidad de los botones al agregar
                    _listaInsumosPlato = new BindingList<InsumoPlatoDTO>();
                    visibilidadBotonesPlatoAgregarEditar();
                    visibilidadBotonesIngredientesVer();
                    editarIngredientes.Visible = false;
                    dgvIngredientes.Visible = false;
                    lbFechaBaja.Text = "-";

                    _plato.ListaInsumos = new List<PlatoInsumo>();
                    dgvIngredientes.DataSource = _listaInsumosPlato;
                }
                else
                {
                    //visibilidad de los botones al ver detalle
                    visibilidadBotonesPlatoVer();
                    visibilidadBotonesIngredientesVer();
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


        private void visibilidadBotonesPlatoAgregarEditar()
        {
            txtNombrePlato.Enabled = true;
            cbPlatoActivo.Enabled = true;
            cbTipoPlato.Enabled = true;           
            btnGuardar.Visible = true;
            btnEditarPlato.Visible = false;
        }

        private void visibilidadBotonesIngredientesAgregarEditar()
        {
            btnEliminarIngrediente.Visible = true;
            lblCantidad.Visible = true;
            lblIngrediente.Visible = true;
            cbIngredientes.Visible = true;
            txtCantidad.Visible = true;
            btnEliminarIngrediente.Visible = true;
            btnAgregarIngrediente.Visible = true;
            btnEditarIngrediente.Visible = true;
            editarIngredientes.Visible = false;
        }

        private void visibilidadBotonesIngredientesVer()
        {
            btnEliminarIngrediente.Visible = false;
            lblCantidad.Visible = false;
            lblIngrediente.Visible = false;
            cbIngredientes.Visible = false;
            txtCantidad.Visible = false;
            btnEliminarIngrediente.Visible = false;
            btnAgregarIngrediente.Visible = false;          
        }

        private void visibilidadBotonesPlatoVer()
        {
            txtNombrePlato.Enabled = false;
            cbPlatoActivo.Enabled = false;
            cbTipoPlato.Enabled = false;
            btnEditarPlato.Visible = true;
            btnGuardar.Visible = false;
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



        private void cbPlatoActivo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cbPlatoActivo.Text == "Si")
                {
                    lbFechaBaja.Text = "-";
                }
                else if (cbPlatoActivo.Text == "No")
                {
                    if (_plato.FechaBaja == null)
                    {
                        lbFechaBaja.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        lbFechaBaja.Text = _plato.FechaBaja.ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cambiar el estado del plato");
                MessageBox.Show("Error al cambiar el estado del plato");
            }
        }

        private void btnEditarPlato_Click_1(object sender, EventArgs e)
        {
            visibilidadBotonesPlatoAgregarEditar();
        }

        private void dgvIngredientes_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                InsumoPlatoDTO insumoSeleccionado = (InsumoPlatoDTO)dgvIngredientes.CurrentRow.DataBoundItem;
                if (insumoSeleccionado == null)
                    return;
                Insumo ins = _insumos.Find(_insumo => _insumo.IdInsumo == insumoSeleccionado.IdInsumo);
                cbIngredientes.SelectedValue = ins.IdInsumo;
                txtCantidad.Text = insumoSeleccionado.CantidadNecesaria.ToString();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al seleccionar insumo en la grilla");
            }
        }

        private void editarIngredientes_Click(object sender, EventArgs e)
        {
            visibilidadBotonesIngredientesAgregarEditar();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                _plato.Nombre = txtNombrePlato.Text;
                _plato.TipoPlato = cbTipoPlato.Text;
                _plato.FechaBaja = cbPlatoActivo.Text == "Si" ? null : (DateTime?)DateTime.Now;

                bool exito = false;
                if(_modo == "editar")
                    exito = _chefBLL.EditarPlato(_plato);
                else
                 exito = _chefBLL.AgregarPlato(_plato);


                if (exito)
                {
                    MessageBox.Show("Se guardaron los cambios");
                    if (_modo == "agregar") { 
                        _modo = "editar";
                        visibilidadBotonesIngredientesAgregarEditar();
                        editarIngredientes.Visible = false;
                        dgvIngredientes.Visible = true;
                        _listaInsumosPlato = InsumoPlatoDTO.mapPlatoInsumoListToInsumoPlatoDTOBindingList(_plato.ListaInsumos);
                        cargarInsumos();
                    }
                }
                else
                {
                    MessageBox.Show("No se pudieron guardar los cambios, intentelo nuevamente mas tarde");
                    this.Close();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                logger.Error(ex, "Error de validación al agregar plato en BLL");
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al guardar los cambios del plato, intentelo nuevamente mas tarde");
                this.Close();
            }
        }


        private void tabIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabIngredientes.SelectedTab == tabPage2 && _modo != "editar")
            {
                MessageBox.Show("Debe crear el plato para agregar ingredientes");
            }
        }

        private void btnAgregarIngrediente_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<string> errores = new List<string>();
                errores.Add(_chefBLL.cantidadInvalida(txtCantidad.Text));
                errores.Add(_chefBLL.IngredienteDuplicado((int)cbIngredientes.SelectedValue, _listaInsumosPlato));
                foreach (string error in errores)
                {
                    if (error != null)
                    {
                        MessageBox.Show(error);
                        return;
                    }
                }

                int idInsumo = (int)cbIngredientes.SelectedValue;
                Insumo ins = _insumos.Find(_insumo => _insumo.IdInsumo == idInsumo);
                InsumoPlatoDTO insumoPlato = new InsumoPlatoDTO(0, ins.IdInsumo, Decimal.Parse(txtCantidad.Text, new CultureInfo("es-ES")), ins.Nombre, ins.UnidadMedida);
                bool exito = _chefBLL.AgregarIngredientePlato(_plato.IdPlato, insumoPlato);
                if (!exito)
                {
                    MessageBox.Show("No se pudo agregar el ingrediente al plato, intentelo nuevamente mas tarde");
                    return;
                }
                _listaInsumosPlato.Add(insumoPlato);

            }
            catch (Exception ex)
            {
                logger.Error("No se pudo agregar el ingrediente al plato, intentelo nuevamente mas tarde");
            }
        }

        private void btnEditarIngrediente_Click_1(object sender, EventArgs e)
        {
            try
            {
                InsumoPlatoDTO insumoSeleccionado = (InsumoPlatoDTO)dgvIngredientes.CurrentRow.DataBoundItem;
                List<string> errores = new List<string>();
                errores.Add(_chefBLL.sinPlatoSeleccionado(insumoSeleccionado));
                errores.Add(_chefBLL.cantidadInvalida(txtCantidad.Text));
                foreach (string error in errores)
                {
                    if (error != null)
                    {
                        MessageBox.Show(error);
                        return;
                    }
                }
                
                Decimal cantidad = insumoSeleccionado.CantidadNecesaria;
                string ingrediente = insumoSeleccionado.NombreInsumo;
                int idInsumo = insumoSeleccionado.IdInsumo;
                _chefBLL.editarInsumo(insumoSeleccionado, _insumos, (int)cbIngredientes.SelectedValue, txtCantidad.Text);
                bool exito = _chefBLL.EditarIngredientePlato(_plato.IdPlato, insumoSeleccionado);

                if (!exito)
                {
                    // Si no se pudo editar, revertimos los cambios
                    insumoSeleccionado.CantidadNecesaria = cantidad;
                    insumoSeleccionado.NombreInsumo = ingrediente;
                    insumoSeleccionado.IdInsumo = idInsumo;
                    MessageBox.Show("No se pudo editar el ingrediente del plato, intentelo nuevamente mas tarde");
                }
                    
                             
            }
            catch (Exception ex)
            {
                logger.Error("No se pudo editar el ingrediente del plato, intentelo nuevamente mas tarde");
            }

        }

        private void btnEliminarIngrediente_Click(object sender, EventArgs e)
        {
            try
            {
                InsumoPlatoDTO insumo = (InsumoPlatoDTO)dgvIngredientes.CurrentRow.DataBoundItem;
                bool exito = _chefBLL.EliminarIngredientePlato(insumo);
                if (!exito)
                {
                    MessageBox.Show("No se pudo eliminar el ingrediente del plato, intentelo nuevamente mas tarde");
                    return;
                }
                _listaInsumosPlato.Remove(insumo);
            }
            catch (Exception ex)
            {
                logger.Error("Error al editar grilla ingrediente");
            }
        }
    }
}

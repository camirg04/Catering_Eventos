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
    public partial class UILogistica : Form, PerfilUsuario
    {
        private Usuario _usuario;
        private List<LoteInsumoDTO> _lote = new List<LoteInsumoDTO>();
        private List<Insumo> _insumo = new List<Insumo>();
        private List<PedidoInsumo> _pedido= new List<PedidoInsumo>();
        private readonly LogisticaBLL _logisticaBLL;
        private readonly HelperFront _helperFront;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public UILogistica(Usuario user)
        {
            InitializeComponent();
            _usuario = user;
            _logisticaBLL = new LogisticaBLL();
            _helperFront = new HelperFront();

            //instancio blllote para trearme todos los lotes
            SetearFiltrosIniciales();
            CargarDgvLotes();

            //me traigo todos los insumos
            InsumoBLL insumoBll = new InsumoBLL();
            _insumo.AddRange(_logisticaBLL.BuscarInsumos("",""));

            //inicializamos data grid de PEDIDO INSUMO
            ReestablecerFiltros();
            CargarDgvPedidos();

            _helperFront.cargarComboIsumos(this.cbProductoLote, _insumo.ToList());
            _helperFront.cargarComboIsumos(this.cbProductoPedido, _insumo.ToList());            
        }


        private void CargarDgvLotes()
        {
            var fechaDesde = dtDesdeLote.Value;
            var fechaHasta = dtHastaLote.Value;
            var insumoSeleccionado = cbProductoLote.SelectedValue == null ? 0 : (int)cbProductoLote.SelectedValue;
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = _logisticaBLL.BuscarLotesInsumos(insumoSeleccionado, fechaDesde, fechaHasta);
            dataGridView2.Columns["Severidad"].Visible = false;
            dataGridView2.Columns["IdLoteInsumo"].Visible = false;
            dataGridView2.Columns["IdInsumo"].Visible = false;
            dataGridView2.Columns["IdPedidoInsumo"].Visible = false;
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

            //cargar insumos
            cargarDgvInsumos(_logisticaBLL.BuscarInsumos(null, null));
            _helperFront.cargarComboSiNo(cbInsumoActivo);
           
        }

        private void cargarDgvInsumos(List<Insumo> insumos)
        {
            dgvInsumos.DataSource = null;
            dgvInsumos.ReadOnly = true;
            dgvInsumos.DataSource = insumos;
            dgvInsumos.Columns["IdInsumo"].Visible = false;
            dgvInsumos.Columns["Perecedero"].Visible = false;
        }

        /*EVENTOS  PARA STOCK*/
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDgvLotes();
            }
            catch (Exception ex) {
                MessageBox.Show("Error al cargar los lotes: " + ex.Message);
            }

        }

        private void SetearFiltrosIniciales()
        {
            dtDesdeLote.Value = DateTime.Now.AddDays(-20);
            dtHastaLote.Value = DateTime.Now.AddDays(10);
            cbProductoLote.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetearFiltrosIniciales();
            CargarDgvLotes();
        }

        private void btnBuscarMenu_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = tbNombreInsumo.Text;
                string activo = cbInsumoActivo.Text;
                cargarDgvInsumos(_logisticaBLL.BuscarInsumos(nombre, activo));
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al buscar insumos");
                MessageBox.Show("Error al buscar insumos");

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cargarDgvInsumos(_logisticaBLL.BuscarInsumos(null, null));
        }

        private void btnVerDetalleMenu_Click(object sender, EventArgs e)
        {
            if (dgvInsumos.CurrentRow == null)
            {
                return;
            }
            var insumo = (Insumo)dgvInsumos.CurrentRow.DataBoundItem;

            var editarInsumo = new DetalleInsumo(insumo, "editar");
            editarInsumo.ShowDialog();
            cargarDgvInsumos(_logisticaBLL.BuscarInsumos(null, null));
        }

        private void btnAgregarMenu_Click(object sender, EventArgs e)
        {
            var editarInsumo = new DetalleInsumo(new Insumo(), "agregar");
            editarInsumo.ShowDialog();
            cargarDgvInsumos(_logisticaBLL.BuscarInsumos(null, null));
        }



        private void CargarDgvPedidos()
        {
            var fechaDesde = dtFechaDesdePedido.Value;
            var fechaHasta = dtFechaHastaPedido.Value;
            var insumoSeleccionado = cbProductoPedido.SelectedValue == null ? 0 : (int)cbProductoPedido.SelectedValue;
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = PedidoInsumoDTO.mapListPedidoInsumoToListPedidoInsumoDTO(_logisticaBLL.BuscarPedidos(insumoSeleccionado,fechaDesde,fechaHasta));
            dataGridView1.Columns["IdPedidoInsumo"].Visible = false;
            dataGridView1.Columns["IdInsumo"].Visible = false;
        }

        private void ReestablecerFiltros()
        {
            dtFechaDesdePedido.Value = DateTime.Now.AddDays(-20);
            dtFechaHastaPedido.Value = DateTime.Now.AddDays(10);
            cbProductoPedido.SelectedIndex = -1;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            CargarDgvPedidos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReestablecerFiltros();
            CargarDgvPedidos();
        }

        private void btnVerDetallePedido_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            var pedido = (PedidoInsumoDTO)dataGridView1.CurrentRow.DataBoundItem;

            var editarPedido = new EditarPedido(pedido, "editar",_insumo,_usuario);
            editarPedido.ShowDialog();
            ReestablecerFiltros();
            CargarDgvPedidos();
            CargarDgvLotes();
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            var editarPedido = new EditarPedido(new PedidoInsumoDTO(), "agregar", _insumo,_usuario);
            editarPedido.ShowDialog();
            ReestablecerFiltros();
            CargarDgvPedidos();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
                return;
            var lote = (LoteInsumoDTO)dataGridView2.CurrentRow.DataBoundItem;

            var ditarLote = new EditarLote(lote);
            ditarLote.ShowDialog();
            SetearFiltrosIniciales();
            CargarDgvLotes();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}

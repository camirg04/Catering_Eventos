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
            CargarDgvLotes();

            //me traigo todos los insumos
            InsumoBLL insumoBll = new InsumoBLL();
            _insumo.AddRange(_logisticaBLL.BuscarInsumos("",""));

            //inicializamos data grid de PEDIDO INSUMO
            ReestablecerFiltros();
            CargarDgvPedidos();

            _helperFront.cargarComboIsumos(this.comboBox1, _insumo.ToList());
            _helperFront.cargarComboIsumos(this.cbProductoPedido, _insumo.ToList());            
        }


        private void CargarDgvLotes()
        {
            LoteInsumoBLL loteInsumoBLL = new LoteInsumoBLL();
            _lote.AddRange(loteInsumoBLL.ObtenerLotesInsumos());
            dataGridView2.DataSource = _lote.ToList();
            dataGridView2.Columns["Severidad"].Visible = false;
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
            string idInsumo = this.comboBox1.SelectedValue.ToString();
            string fechaIngresoInicio = this.dateTimePicker2.Text;
            string fechaIngresoFin = this.dateTimePicker1.Text;

            if (idInsumo == "")
            {
                MessageBox.Show("Tiene que tener un producto");
            }
            else
            {
                LoteInsumoBLL loteInsumoBLL = new LoteInsumoBLL();
                Console.WriteLine(loteInsumoBLL.BuscarLotePorId(int.Parse(idInsumo), fechaIngresoInicio, fechaIngresoFin).Count);
                _lote.Clear();
                _lote.AddRange(loteInsumoBLL.BuscarLotePorId(int.Parse(idInsumo), fechaIngresoInicio, fechaIngresoFin));
                dataGridView2.DataSource = _lote.ToList();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            LoteInsumoBLL loteInsumoBLL = new LoteInsumoBLL();
            _lote.Clear();
            _lote.AddRange(loteInsumoBLL.ObtenerLotesInsumos());
            dataGridView2.DataSource = _lote.ToList();
            dataGridView2.Columns["Severidad"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex != -1)
            //{
            //    if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
            //    {
            //        //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

            //        if (dataGridView1.Rows[e.RowIndex].Cells["EstadoPedido"].Value.ToString() != "ENTREGADO")
            //        {
            //            //vemos el campo estadoPedido
            //            if (dataGridView1.Rows[e.RowIndex].Cells["EstadoPedido"].Value.ToString() == "ENTREGADO")
            //            {
            //                comboBox6.SelectedIndex = 1;
            //            }
            //            else
            //            {
            //                comboBox6.SelectedIndex = 0;
            //            }
            //            //sacamos la cantidad
            //            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString();
            //            //sacamos la fecha del pedido
            //            dateTimePicker6.Text = dataGridView1.Rows[e.RowIndex].Cells["FechaPedido"].Value.ToString();
            //            //creo un insumo que esta en el campo INSUMO
            //            Insumo OneInsumo = new Insumo();
            //            OneInsumo = dataGridView1.Rows[e.RowIndex].Cells["Insumo"].Value as Insumo;
            //            //matcheo el id con el value -- idInsumo
            //            comboBox7.SelectedValue = OneInsumo.IdInsumo;
            //            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["IdPedidoInsumo"].Value.ToString();
            //            //creo un usuario
            //            Usuario OneUsuario = new Usuario();
            //            OneUsuario = dataGridView1.Rows[e.RowIndex].Cells["UsuarioPedido"].Value as Usuario;
            //            textBox4.Text = OneUsuario.IdUsuario.ToString();
            //        }
            //        else
            //        {
            //            MessageBox.Show("El Insumo ya fue entregado");
            //        }
                    

            //    }

            //}
        }


        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex != -1)
                {
                    if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
                    {
                        //text 5 -> insumo
                        //text6 -> unidad medida
                        //text7 -> cantidad ->
                        //text8 -> costo unit
                        //datetime 7 -> fechavence
                        decimal cantidad = decimal.Parse(dataGridView2.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());//decimal.Parse(textBox5.Text);
                        DateTime fecha_vence = DateTime.Parse(dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString());
                        string insumo = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                        string idPedidoInsumo = dataGridView2.Rows[e.RowIndex].Cells["idLoteInsumo"].Value.ToString();
                        string unidad = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                        decimal costo = decimal.Parse(dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString());

                        textBox5.Text = insumo;
                        textBox6.Text = unidad;
                        textBox7.Text = cantidad.ToString();
                        textBox8.Text = costo.ToString();
                        textBox9.Text  = idPedidoInsumo.ToString();
                        dateTimePicker7.Value = fecha_vence;
                    }
                }

            }
            catch(Exception ex) {  MessageBox.Show(ex.Message); }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox9.Text != "")
                {
                    int idLote = int.Parse(textBox9.Text);
                    decimal costo = Decimal.Parse(textBox8.Text);
                    DateTime vence = dateTimePicker7.Value;
                    LoteInsumoBLL loteBll = new LoteInsumoBLL();
                    loteBll.ActualizarCostoFechaLote(idLote, costo, vence);

                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    dateTimePicker7.Value = DateTime.Now;
                    MessageBox.Show("Los datos se actualizaron");

                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }


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
    }
}

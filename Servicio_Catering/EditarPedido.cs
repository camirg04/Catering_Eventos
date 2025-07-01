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

namespace Servicio_Catering
{
    public partial class EditarPedido : Form
    {
        private PedidoInsumoDTO _pedidoInsumo;
        private string _modo;
        private List<Insumo> _insumos;
        private HelperFront _helperFront;
        private LogisticaBLL _logisticaBLL = new LogisticaBLL();
        private Usuario _user;

        public EditarPedido(PedidoInsumoDTO pedido, string modo,List<Insumo> insumos, Usuario user)
        {
            InitializeComponent();
            _pedidoInsumo = pedido;
            _modo = modo;
            _insumos = insumos;
            _helperFront = new HelperFront();
            _user = user;
        }

        private void EditarPedido_Load(object sender, EventArgs e)
        {
            _helperFront.cargarComboIsumos(cbProducto, _insumos);
            _helperFront.cargarComboEstadoPedido(cbEstado);
            PrecargarDatos();
        }

        private void PrecargarDatos()
        {
            if(_modo == "editar")
            {
                tbCantidad.Text = _pedidoInsumo.Cantidad.ToString();
                dtFecha.Value = _pedidoInsumo.FechaPedido ?? DateTime.Now;
                cbEstado.SelectedItem = _pedidoInsumo.EstadoPedido;
                cbProducto.SelectedValue = _pedidoInsumo.IdInsumo;
                cbEstado.SelectedItem = _pedidoInsumo.EstadoPedido;
                tbCantidad.Enabled = false;
                dtFecha.Enabled = false;
                cbProducto.Enabled = false;
                cbEstado.Enabled = false;
                btnGuardarMenu.Visible = false;
                btnEditarMenu.Visible = true;

            }
            else
            {
                cbEstado.SelectedItem = "PENDIENTE";
                cbEstado.Enabled = false;
                tbCantidad.Enabled = true;
                dtFecha.Enabled = true;
                cbProducto.Enabled = true;
                btnGuardarMenu.Visible = true;
                btnEditarMenu.Visible = false;
            }          
        }

        private void btnEditarMenu_Click(object sender, EventArgs e)
        {
            cbEstado.Enabled = true;
            tbCantidad.Enabled = true;
            dtFecha.Enabled = true;
            cbProducto.Enabled = true;
            btnGuardarMenu.Visible = true;
            btnEditarMenu.Visible = false;
        }

        private void btnGuardarMenu_Click(object sender, EventArgs e)
        {
            try
            {
                _logisticaBLL.ValidarDatosPedido(cbProducto.Text, tbCantidad.Text, cbEstado.Text);
                bool exito = false;
                string mensaje = "Pedido guardado correctamente.";
                if (_modo != "editar")
                {
                    exito = _logisticaBLL.AgregarPedido(
                        Convert.ToInt32(cbProducto.SelectedValue),
                        dtFecha.Value,
                        cbEstado.Text,
                        Convert.ToDecimal(tbCantidad.Text),
                        _user.IdUsuario);
                }
                else
                {
                    exito = _logisticaBLL.EditarPedido(
                        Convert.ToInt32(cbProducto.SelectedValue),
                        _pedidoInsumo.IdPedidoInsumo,
                        dtFecha.Value,
                        cbEstado.Text,
                        Convert.ToDecimal(tbCantidad.Text),
                        0, // Costo no se usa en este contexto
                        _pedidoInsumo.EstadoPedido);
                    if(cbEstado.Text == "ENTREGADO")
                    {
                        mensaje = "Se creó el lote para el pedido de " + cbProducto.Text + ". Modifique el costo, y la fecha de vencimiento si es un producto perecedero";
                    }
                }

                if (exito)
                {
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el pedido. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el pedido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

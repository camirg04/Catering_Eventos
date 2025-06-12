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
using DTO_Catering;
using System.Xml.Serialization;

namespace Servicio_Catering
{
    public partial class Administracion : Form, PerfilUsuario
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly Chef _usuario;
        private readonly HelperFront _helperFront;
        private readonly ChefBLL _chefBLL;
        private readonly InsumoBLL _insumoBLL;

        public Administracion(Chef user)
        {
            InitializeComponent();
            _usuario = user;
            _helperFront = new HelperFront();
            _chefBLL = new ChefBLL();
            _insumoBLL = new InsumoBLL();
        }


        private void ObtenerPlatosFiltro()
        {
            try
            {
                string nombrePLato = txtNombre.Text;
                string tipoPlato = cbTipoPlato.Text;
                string activo = cbActivo.Text;
                List<Plato> platos = _chefBLL.BuscarPlatos(nombrePLato, tipoPlato, activo);
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
                lblBienvenida.Text = darBienvenida(_usuario.Nombre);

                //Cargas iniciales de evento
                //para que el date time picker se vea como dd/mm/yyyy
                fechaDesdeEvento.Format = DateTimePickerFormat.Short;
                fechaHastaEvento.Format = DateTimePickerFormat.Short;
                fechaDesdeEvento.Value = DateTime.Now;
                fechaHastaEvento.Value = DateTime.Now.AddDays(60);
                dgvEventos.DataSource = _chefBLL.ObtenerEventosPorFechaYEstado(fechaDesdeEvento.Value, fechaHastaEvento.Value, null);
                dgvEventos.Columns["IdEvento"].Visible = false;
                dgvEventos.Columns["IdCliente"].Visible = false;
                dgvEventos.Columns["IdMenu"].Visible = false;
                dgvEventos.Columns["IdEvento"].Visible = false;
                dgvEventos.Columns["UsuarioVenta"].Visible = false;
                dgvEventos.Columns["DescuentoAplicado"].Visible = false;
                dgvEventos.Columns["TotalEstimado"].Visible = false;
                dgvEventos.Columns["EventoPago"].Visible = false;

                //Cargas iniciales de plato
                dgvPlatos.ReadOnly = true;
                ObtenerPlatosFiltro();
                _helperFront.cargarComboTipoPlato(cbTipoPlato);
                _helperFront.cargarComboSiNo(cbActivo);

                //Cargas iniciales de alertas
                dateTimeDesdeAlerta.Format = DateTimePickerFormat.Short;
                dateTimeHastaAlerta.Format = DateTimePickerFormat.Short;
                dateTimeDesdeAlerta.Value = DateTime.Now.AddDays(-10);
                dateTimeHastaAlerta.Value = DateTime.Now;
                _helperFront.cargarComboEstadoAlerta(cbEstadoAlerta);
                CargarDgvAlerta(_chefBLL.ObtenerAlertasStock(dateTimeDesdeAlerta.Value, dateTimeHastaAlerta.Value, null));
                AlertaSeveridadCritica(dgvAlertas);

                //Cargas iniciales de vencimientos
                dateTimeDesdeVencimiento.Format = DateTimePickerFormat.Short;
                dateTimeHastaVencimiento.Format = DateTimePickerFormat.Short;
                dateTimeDesdeVencimiento.Value = DateTime.Now;
                dateTimeHastaVencimiento.Value = DateTime.Now.AddDays(7);
                dgvVencimientos.ReadOnly = true;
                dgvVencimientos.DataSource = _chefBLL.ObtenerLotesInsumosPerecederos(dateTimeDesdeVencimiento.Value, dateTimeHastaVencimiento.Value);
                dgvVencimientos.Columns["IdLoteInsumo"].Visible = false;
                dgvVencimientos.Columns["IdPedidoInsumo"].Visible = false;
                dgvVencimientos.Columns["IdInsumo"].Visible = false;

                dgvAlertas.CellFormatting += dgvAlertas_CellFormatting;
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




        private void AlertaSeveridadCritica(DataGridView dgv)
        {
            bool critico = false;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                var estado = row.Cells["Severidad"].Value?.ToString();

                if (estado == "Crítica")
                {
                    critico = true;
                }

            }

            if (critico)
            {
                MessageBox.Show("¡Tiene alertas de stock en estado crítico!");
            }
        
        }

        private void dgvAlertas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Nos aseguramos de que no sea una fila de encabezado ni una celda vacía
            var fila = dgvAlertas.Rows[e.RowIndex];

            if (fila.Cells["Severidad"].Value == null)
                return;

            string estado = fila.Cells["Severidad"].Value.ToString();

            if (estado == "Crítica")
            {
                fila.DefaultCellStyle.BackColor = Color.Red;
                fila.DefaultCellStyle.ForeColor = Color.White;
            }else if (estado == "Mayor")
            {
                fila.DefaultCellStyle.BackColor = Color.Orange;
                fila.DefaultCellStyle.ForeColor = Color.White;
            }else if(estado == "Menor")
            {
                fila.DefaultCellStyle.BackColor = Color.Yellow;
                fila.DefaultCellStyle.ForeColor = Color.Black;
            }
            else
            {
                fila.DefaultCellStyle.BackColor = Color.Green;
                fila.DefaultCellStyle.ForeColor = Color.White;
            }
        }


        private void CargarDgvAlerta(List<AlertaStockDTO> alertas)
        {
            dgvAlertas.ReadOnly = true;
            dgvAlertas.DataSource = alertas;
            dgvAlertas.Columns["IdAlertaStock"].Visible = false;
            dgvAlertas.Columns["IdInsumo"].Visible = false;
        }


        private void btnBuscarAlerta_Click(object sender, EventArgs e)
        {
            var fechaDesde = dateTimeDesdeAlerta.Value;
            var fechaHasta = dateTimeHastaAlerta.Value;
            string estado = cbEstadoAlerta?.Text == "" ? null : cbEstadoAlerta.Text;
            CargarDgvAlerta(_chefBLL.ObtenerAlertasStock(fechaDesde, fechaHasta, estado));
        }
    }
}

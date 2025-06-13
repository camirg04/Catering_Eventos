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
                dgvAlertas.ReadOnly = true;
                dgvAlertas.DataSource = _chefBLL.ObtenerAlertasStock(dateTimeDesdeAlerta.Value,dateTimeHastaAlerta.Value,null);
                dgvAlertas.Columns["IdAlertaStock"].Visible = false;
                dgvAlertas.Columns["IdInsumo"].Visible = false;
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
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar la ventana de administración");
                MessageBox.Show("Error al cargar la ventana de administración");
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
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
            PlatoDetalle platoDetalle = new PlatoDetalle(plato, "agregar");
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

                if (estado != "Crítica")
                {
                    critico = true;
                }

            }

            if (critico)
            {
                MessageBox.Show("¡Tiene alertas de stock en estado crítico!");
            }

        }












        //MOCKS DATOS
        private List<AlertaStockDTO> getMockAlertas()
        {
            var lista = new List<AlertaStock>
            {
                new AlertaStock(1, new Insumo(1, "Harina", "kg", false, 20, null), "PENDIENTE", DateTime.Now.AddDays(-1)),
                new AlertaStock(2, new Insumo(2, "Leche", "litros", true, 10, null), "RESUELTO", DateTime.Now.AddDays(-2)),
                new AlertaStock(3, new Insumo(3, "Huevos", "docena", true, 5, null), "PENDIENTE", DateTime.Now.AddDays(-3)),
                new AlertaStock(4, new Insumo(4, "Azúcar", "kg", false, 15, null), "RESUELTO", DateTime.Now.AddDays(-4)),
                new AlertaStock(5, new Insumo(5, "Manteca", "kg", true, 8, null), "PENDIENTE", DateTime.Now.AddDays(-5)),
                new AlertaStock(6, new Insumo(6, "Sal", "kg", false, 12, null), "RESUELTO", DateTime.Now.AddDays(-6)),
                new AlertaStock(7, new Insumo(7, "Queso", "kg", true, 6, null), "PENDIENTE", DateTime.Now.AddDays(-7)),
                new AlertaStock(8, new Insumo(8, "Aceite", "litros", false, 18, null), "RESUELTO", DateTime.Now.AddDays(-8)),
                new AlertaStock(9, new Insumo(9, "Tomate", "kg", true, 9, null), "PENDIENTE", DateTime.Now.AddDays(-9)),
                new AlertaStock(10, new Insumo(10, "Pimienta", "gr", false, 2, null), "RESUELTO", DateTime.Now.AddDays(-10))
            };
            return AlertaStockDTO.mapListAlertaStockToListAlertaStockDTO(lista);
        }


        private List<LoteInsumoDTO> getMockLotes()
        {
            var usuario1 = new Usuario(1, "admin@mail.com", "1234", "Admin", "admin@mail.com", DateTime.Now.AddMonths(-3), null, "12345678", "Juan", "Pérez", "Calle 123", "123456789");
            var usuario2 = new Usuario(2, "chef@mail.com", "chef123", "Chef", "chef@mail.com", DateTime.Now.AddMonths(-2), null, "87654321", "María", "Gómez", "Calle 456", "987654321");

            var insumo1 = new Insumo(1, "Harina", "Kg", true, 50, null);
            var insumo2 = new Insumo(2, "Aceite", "Litros", false, 20, null);

            var pedido1 = new PedidoInsumo(1, insumo1, usuario1, 100, DateTime.Now.AddDays(-15), "PENDIENTE");
            var pedido2 = new PedidoInsumo(2, insumo2, usuario2, 50, DateTime.Now.AddDays(-10), "RESUELTO");

            var lote1 = new LoteInsumo(1, insumo1, pedido1, 100, 150.75m, DateTime.Now.AddDays(-14), DateTime.Now.AddMonths(6));
            var lote2 = new LoteInsumo(2, insumo2, pedido2, 50, 300.00m, DateTime.Now.AddDays(-9), null);
            var lote3 = new LoteInsumo(3, insumo1, pedido1, 30, 155.00m, DateTime.Now.AddDays(-5), DateTime.Now.AddMonths(5));
            var lote4 = new LoteInsumo(4, insumo2, pedido2, 80, 290.00m, DateTime.Now.AddDays(-20), null);
            var lote5 = new LoteInsumo(5, insumo1, pedido1, 120, 148.25m, DateTime.Now.AddDays(-2), DateTime.Now.AddMonths(4));

            var lista = new List<LoteInsumo>
            {
                lote1,
                lote2,
                lote3,
                lote4,
                lote5
            };
            return LoteInsumoDTO.mapLoteInsumoListToLoteInsumoDTOList(lista);
        }

    }
}

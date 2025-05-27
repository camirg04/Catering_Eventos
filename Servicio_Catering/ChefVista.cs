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
        private readonly Usuario _usuario;
        private readonly HelperFront _helperFront;
        private readonly PlatoBLL _platoBLL;
        private readonly LoteInsumoBLL _loteInsumoBLL;
        private readonly InsumoBLL _insumoBLL;

        public Administracion(Usuario user)
        {
            InitializeComponent();
            _usuario = user;
            _helperFront = new HelperFront();
            _platoBLL = new PlatoBLL();
            _loteInsumoBLL = new LoteInsumoBLL();
            _insumoBLL = new InsumoBLL();
        }


        private void ObtenerPlatosFiltro()
        {
            try
            {
                string nombrePLato = txtNombre.Text;
                string tipoPlato = cbTipoPlato.Text;
                string activo = cbActivo.Text;
                List<Plato> platos = _platoBLL.BuscarPlatos(nombrePLato, tipoPlato, activo);
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
                _helperFront.cargarComboEstadoAlerta(cbEstadoAlerta);
                dgvAlertas.ReadOnly = true;
                dgvAlertas.DataSource = getMockAlertas();
                dgvAlertas.Columns["IdAlertaStock"].Visible = false;
                dgvAlertas.Columns["IdInsumo"].Visible = false;

                //Cargas iniciales de vencimientos
                dgvVencimientos.ReadOnly = true;
                dgvVencimientos.DataSource = _loteInsumoBLL.ObtenerLotesInsumos();
                _helperFront.cargarComboIsumos(cbInsumosVencimientos, _insumoBLL.ObtenerInsumosActivos());
                dgvVencimientos.Columns["IdLoteInsumo"].Visible = false;
                dgvVencimientos.Columns["IdInsumo"].Visible = false;

                //Cargas iniciales de eventos
                dgvEventos.ReadOnly = true;
                dgvEventos.DataSource = getMockEvento();
                dgvEventos.Columns["IdEvento"].Visible = false;
                dgvEventos.Columns["IdCliente"].Visible = false;
                dgvEventos.Columns["IdMenu"].Visible = false;
                dgvEventos.Columns["DescuentoAplicado"].DefaultCellStyle.Format = "P2";


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



        private List<EventoDTO> getMockEvento()
        {
            var eventos = new List<Evento>();

            var cliente1 = new Cliente("Lucía", "Pérez", "lucia.perez@mail.com", "1123456789", "Av. Siempre Viva 123", "33111222");
            var cliente2 = new Cliente("Carlos", "Gómez", "carlos.gomez@mail.com", "1133344555", "Calle Falsa 456", "22123456");
            var cliente3 = new Cliente("María", "Fernández", "maria.fernandez@mail.com", "1144556677", "San Martín 789", "27272727");
            var cliente4 = new Cliente("Julián", "Lopez", "julian.lopez@mail.com", "1166778899", "Independencia 321", "30303030");
            var cliente5 = new Cliente("Sofía", "Martínez", "sofia.martinez@mail.com", "1199887766", "Belgrano 654", "34343434");

            var menu1 = new Entity_Catering.Menu("Menú Clásico", 2500);
            var menu2 = new Entity_Catering.Menu("Menú Premium", 4500);
            var menu3 = new Entity_Catering.Menu("Menú Vegetariano", 2800);
            var menu4 = new Entity_Catering.Menu("Menú Gourmet", 5000);
            var menu5 = new Entity_Catering.Menu("Menú Infantil", 2000);

            var usuario1 = new Usuario(1, "venta1@mail.com", "clave123", "Vendedor", "venta1@mail.com", DateTime.Now.AddMonths(-2), null, "12345678", "Juan", "Pérez", "Mitre 123", "1122334455");
            var usuario2 = new Usuario(2, "venta2@mail.com", "clave456", "Vendedor", "venta2@mail.com", DateTime.Now.AddMonths(-1), null, "87654321", "Ana", "García", "Rivadavia 456", "1166778899");

            // Crear eventos
            eventos.Add(new Evento(cliente1, menu1, usuario1, new DateTime(2025, 7, 15), 0.2m, "Salón A", "Palermo", "Confirmado", 100, 250000m, false));
            eventos.Add(new Evento(cliente2, menu2, usuario2, new DateTime(2025, 8, 20), 0.5m, "Quinta Los Robles", "Tigre", "Pendiente", 150, 675000m, false));
            eventos.Add(new Evento(cliente3, menu3, usuario1, new DateTime(2025, 9, 10), 0m, "Salón Azul", "Recoleta", "Confirmado", 80, 224000m, true));
            eventos.Add(new Evento(cliente4, menu4, usuario2, new DateTime(2025, 10, 5), 0.1m, "Estancia La María", "Pilar", "Cancelado", 200, 990000m, false));
            eventos.Add(new Evento(cliente5, menu5, usuario1, new DateTime(2025, 12, 24), 0.2m, "Club Social", "San Isidro", "Confirmado", 60, 118000m, true));

            return EventoDTO.mapEventoListToEventoDTOList(eventos);
        }

    }
}

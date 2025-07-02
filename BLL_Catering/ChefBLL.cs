using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Catering;
using DTO_Catering;
using Entity_Catering;
using NLog;

namespace BLL_Catering
{
    public class ChefBLL
    {
        private readonly PlatoBLL _platoBLL;
        private readonly LoteInsumoBLL _loteInsumoBLL;
        private readonly ValidacionesBLL _validaciones;
        private readonly AlertaStockBLL _alertaStockBLL;
        private readonly EventosBLL _eventosBLL;
        private readonly UsuarioBLL _usuarioBLL;
        private readonly EmailService _emailService;
        private readonly MenusBLL _menuBLL;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private bool _bajoStockMinimo = false;
        private bool _bajoStockCritico = false;

        public ChefBLL() {
            _platoBLL = new PlatoBLL();
            _validaciones = new ValidacionesBLL();
            _loteInsumoBLL = new LoteInsumoBLL();
            _alertaStockBLL = new AlertaStockBLL();
            _eventosBLL = new EventosBLL();
            _usuarioBLL = new UsuarioBLL();
            _emailService = new EmailService();
            _menuBLL = new MenusBLL();
        }


        //Métodos platos

        public List<Plato> BuscarPlatos(string nombre, string tipo, string activo)
        {
            try
            {
                return _platoBLL.BuscarPlatos(nombre, tipo, activo);
            }
            catch (Exception e) {
                logger.Error(e.ToString());
                throw;
            }            
        }

        public string sinPlatoSeleccionado(InsumoPlatoDTO insumoSeleccionado)
        {
            if (insumoSeleccionado == null)
            {
                return "Seleccione un insumo para editar";
            }

            return null;
        }

        public string cantidadInvalida(string cantidad)
        {
            bool esDecimal = _validaciones.esDecimal(cantidad);
            if (!esDecimal)
            {
                return "Formato numero incorrecto";
            }
            return null;
        }

        public string IngredienteDuplicado(int idInsumo, BindingList<InsumoPlatoDTO> listInsumos)
        {
            int mismoInsumo = 0;
            foreach (InsumoPlatoDTO insumo in listInsumos)
            {
                if (insumo.IdInsumo == idInsumo)
                {
                    mismoInsumo++;
                }
            }

            if (mismoInsumo >= 1)
            {
                return "No se puede duplicar el insumo en el plato";
            }
            return null;
        }

        public void editarInsumo(InsumoPlatoDTO insumo, List<Insumo> insumos, int idInsumo, string cantidad)
        {
            Insumo ins = insumos.Find(_insumo => _insumo.IdInsumo == idInsumo);
            insumo.CantidadNecesaria = Decimal.Parse(cantidad, new CultureInfo("es-ES"));
            insumo.IdInsumo = ins.IdInsumo;
            insumo.NombreInsumo = ins.Nombre;
            insumo.UnidadMedida = ins.UnidadMedida;
        }

        public bool EditarPlato(Plato plato)
        {
            try
            {
                return _platoBLL.EditarPlato(plato);
            }
            catch (ArgumentException ex)
            {
                logger.Error(ex, "Error de validación al agregar plato en BLL");
                throw ex;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al editar plato en BLL");
                throw ex;
            }
        }

        public bool AgregarPlato(Plato plato)
        {
            try
            {
                return _platoBLL.AgregarPlato(plato);
            }
            catch (ArgumentException ex)
            {
                logger.Error(ex, "Error de validación al agregar plato en BLL");
                throw ex;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al editar plato en BLL");
                throw ex;
            }
        }

        public bool EliminarIngredientePlato(InsumoPlatoDTO insumo)
        {
            try
            {
                return _platoBLL.EliminarIngredientePlato(insumo);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al eliminar plato en BLL");
                throw ex;
            }
        }


        public bool EditarIngredientePlato(int id_plato, InsumoPlatoDTO insumo)
        {
            try
            {
                return _platoBLL.EditarIngredientePlato(id_plato, insumo);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al editar plato en BLL");
                throw ex;
            }
        }


        public bool AgregarIngredientePlato(int id_plato, InsumoPlatoDTO insumo)
        {
            try
            {
                return _platoBLL.AgregarIngredientePlato(id_plato, insumo);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al agregar plato en BLL");
                throw ex;
            }
        }

        
        //Métodos vencimientos

        public List<LoteInsumoDTO> ObtenerLotesInsumosPerecederos(DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                return _loteInsumoBLL.ObtenerLotesInsumosPerecederos(fechaDesde, fechaHasta);
            }
            catch (Exception e)
            {
                logger.Error(e.ToString());
                throw;
            }
        }


        
        //Métodos alertas de stock

        public List<AlertaStockDTO> ObtenerAlertasStock(DateTime fechaDesde, DateTime fechaHasta, string estado)
        {
            try
            {
                return _alertaStockBLL.FiltrarAlertas(fechaDesde,fechaHasta,estado);
            }
            catch (Exception e)
            {
                logger.Error(e.ToString());
                throw;
            }
        }


        public int EditarEstadoAlertaStock(int idInsumo, string estado)
        {
            try
            {
                return _alertaStockBLL.EditarEstadoAlertaStock(idInsumo, estado);
            }
            catch (ArgumentException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al filtrar alertas de stock", ex);
            }
        }


        //Métodos evento / descuento stock

        public List<EventoDTO> ObtenerEventosPorFechaYEstado(DateTime fechaDesde, DateTime fechaHasta, string estado)
        {
            try
            {
                var eventos = _eventosBLL.BuscarEventosPorFechaYEstado(fechaDesde,fechaHasta,estado);
                return EventoDTO.mapEventoListToEventoDTOList(eventos);
            }
            catch (Exception e) { 
                logger.Error(e.ToString());
                throw;
            }
        }

        public void ModificarEstadoEvento(int id_menu, int cantidadPersonas,string estado,int idEvento, string estadoAnterior)
        {
            try
            {
                if(estado != estadoAnterior)
                {
                    if (estadoAnterior == "FINALIZADO")
                    {
                        throw new Exception("No se puede modificar el estado de un evento finalizado.");
                    }
                    if(estadoAnterior == "PENDIENTE" && estado == "FINALIZADO")
                    {
                        throw new Exception("No se puede finalizar un evento sin pasar por el estado EN PROCESO.");
                    }
                    if (estadoAnterior == "PROCESO" && estado == "PENDIENTE")
                    {
                        throw new Exception("No se puede volver a PENDIENTE un evento que ya está en PROCESO.");
                    }

                }
                if (estado == "PROCESO")
                {
                    GestionarStock(id_menu, cantidadPersonas);
                }
                _eventosBLL.ActualizarEstadoEvento(idEvento, estado);
            }
            catch (Exception e)
            {
                logger.Error(e.ToString());
                throw;
            }
            
        }


        private void GestionarStock(int id_menu, int cantidadPersonas)
        {
            var platos = _platoBLL.BuscarPlatosPorMenu(id_menu);
            Dictionary<int, CalculoStock> stockNecesario = ObtenerCantidadesNecesarias(platos, cantidadPersonas);
            var lotes = new List<EventoDTO>();
            CalcularStockDisponible(stockNecesario);
            bool errorMail = false;
            if (_bajoStockCritico || _bajoStockMinimo)
            {
                try
                {
                    EnviarMailSock(stockNecesario);
                    Console.WriteLine("Se enviaron los mails");
                }
                catch (Exception ex)
                {
                    errorMail = true;
                    logger.Error("No se pudo enviar el mail de alerta de stock: " + ex.Message);
                }

                if (_bajoStockCritico)
                {
                    string mensaje = "Stock insuficiente de insumos. \nNo se puede iniciar preparación.\nRevise las alertas de stock";
                    if(errorMail)
                    {
                        mensaje += "\nNo se pudo enviar el mail de alerta de stock.";
                    }
                    throw new Exception(mensaje);
                }
            }
            DescontarStock(stockNecesario);
            if (_bajoStockMinimo)
            {
                throw new Exception("Stock mínimo de insumos. \nRevise las alertas de stock");
            }

        }

        
        private void DescontarStock(Dictionary<int, CalculoStock> stockADescontar)
        {
            try {
                foreach (var kvp in stockADescontar)
                {
                    int idInsumo = kvp.Key;
                    var lotes_ingrediente = _loteInsumoBLL.ObtenerLotesInsumosPorIdInsumo(idInsumo);
                    Decimal stockUsado = kvp.Value.CantidadNecesaria;

                    foreach (var lote in lotes_ingrediente)
                    {
                        if (lote.Cantidad - stockUsado <= 0)
                        {
                            stockUsado -= lote.Cantidad;
                            lote.Cantidad = 0;
                        }
                        else
                        {
                            lote.Cantidad -= stockUsado;
                            stockUsado = 0;
                        }
                        _loteInsumoBLL.ActualizarCantidadLote(lote.IDLoteInsumo, lote.Cantidad);
                    }
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex);
                throw;
            }
        }


        private void EnviarMailSock(Dictionary<int, CalculoStock> stockNecesario)
        {
            try {
                var emails = _usuarioBLL.ObtenerMailsLogisticaChefs();
                var cuerpo = new StringBuilder();

                cuerpo.AppendLine("⚠ INSUMOS CON STOCK CRÍTICO O MÍNIMO");
                cuerpo.AppendLine();
                cuerpo.AppendLine("Los siguientes insumos están por debajo de los umbrales definidos:");
                cuerpo.AppendLine();
                cuerpo.AppendLine("Nombre del insumo              | Stock Disponible | Stock Mínimo | Necesario");
                cuerpo.AppendLine("---------------------------------------------------------------");


                foreach (var kvp in stockNecesario)
                {
                    if (kvp.Value.Mensaje == "STOCK_INSUFICIENTE_ALERTA" || kvp.Value.Mensaje == "STOCK_MINIMO_ALERTA")
                    {
                        var nombre = kvp.Value.Ingrediente.Length > 25
                         ? kvp.Value.Ingrediente.Substring(0, 25)
                         : kvp.Value.Ingrediente.PadRight(25);

                        var disponible = (kvp.Value.Stock.ToString("0.##") + " " + kvp.Value.UnidadMedida).PadLeft(17);
                        var minimo = (kvp.Value.StockMinimo.ToString("0.##") + " " + kvp.Value.UnidadMedida).PadLeft(15);
                        var necesario = (kvp.Value.CantidadNecesaria.ToString("0.##") + " " + kvp.Value.UnidadMedida).PadLeft(12);

                        cuerpo.AppendLine($"{nombre} |{disponible} |{minimo} |{necesario}");
                    }
                  
                }

                string mailTextoPlano = cuerpo.ToString();

            
                foreach (var correo in emails)
                {
                    _emailService.EnviarMail(correo, "ALERTA STOCK", mailTextoPlano);
                }
            }catch (Exception ex)
            {
                logger.Error(ex);
                throw;
            }
            
        }


        private void CalcularStockDisponible(Dictionary<int, CalculoStock> stockNecesario)
        {
            _bajoStockMinimo = false;
            _bajoStockCritico = false;
            foreach (var kvp in stockNecesario)
            {
                int idInsumo = kvp.Key;
                var lotes_ingrediente = _loteInsumoBLL.ObtenerLotesInsumosPorIdInsumo(idInsumo);
                // sumar stock por ingrediente
                decimal totalStock = lotes_ingrediente.Sum(l => l.Cantidad);

                kvp.Value.Stock = totalStock;

                if(totalStock - kvp.Value.CantidadNecesaria < 0)
                {
                    kvp.Value.Mensaje = "STOCK_INSUFICIENTE_ALERTA";
                    _bajoStockCritico = true;
                    try
                    {
                        _alertaStockBLL.InsertarAlertaStock(idInsumo);
                    }
                    catch (Exception ex)
                    {
                        logger.Error("No se pudo registrar la alerta de stock");
                        logger.Error(ex);
                    }
                }
                else if(totalStock - kvp.Value.CantidadNecesaria < kvp.Value.StockMinimo)
                {
                    kvp.Value.Mensaje = "STOCK_MINIMO_ALERTA";
                    _bajoStockMinimo = true;
                    try
                    {
                        _alertaStockBLL.InsertarAlertaStock(idInsumo);
                    }
                    catch (Exception ex){
                        logger.Error("No se pudo registrar la alerta de stock");
                        logger.Error(ex);
                    }
                }
                else
                {
                    kvp.Value.Mensaje = "OK";
                }
            } 
        }


        private Dictionary<int, CalculoStock> ObtenerCantidadesNecesarias(List<Plato> platos, int cantidadPersonas) { 
            Dictionary<int, CalculoStock> result = new Dictionary<int, CalculoStock>();

            foreach (var plato in platos) {
                foreach(var ingrediente in plato.ListaInsumos)
                {
                    int idInsumo = ingrediente.Insumo.IdInsumo;
                    decimal cantidad = ingrediente.CantidadNecesaria;
                    

                    if (result.ContainsKey(idInsumo))
                    {
                        result[idInsumo].CantidadNecesaria +=  cantidad * cantidadPersonas ;                       
                    }
                    else
                    {
                        var calculoStock = new CalculoStock();
                        calculoStock.CantidadNecesaria = cantidad * cantidadPersonas;
                        calculoStock.StockMinimo = ingrediente.Insumo.StockMinimo;
                        calculoStock.UnidadMedida = ingrediente.Insumo.UnidadMedida;
                        calculoStock.Ingrediente = ingrediente.Insumo.Nombre;

                        result.Add(idInsumo, calculoStock);
                    }
                }
            }

            return result;
        }



        //Métodos menús

        public List<Menus> BuscarMenus(string nombre, string activos)
        {
            try
            {
                return _menuBLL.BuscarMenus(nombre, activos);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al buscar menus en BLL");
                throw;
            }
        }

        private Decimal obtenerPrecio(string precio)
        {
            if (string.IsNullOrEmpty(precio))
            {
                throw new ArgumentException("El precio del menú no puede estar vacío.");
            }
            if (!_validaciones.esDecimal(precio))
            {
                throw new ArgumentException("El precio debe ser un número válido.");
            }
            return Decimal.Parse(precio, new CultureInfo("es-ES"));
        }

        public int CrearMenu(string nombre, string precio, DateTime? fechaBaja)
        {         
            try
            {
                return _menuBLL.CrearMenu(nombre, obtenerPrecio(precio), fechaBaja);
            }
            catch (ArgumentException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al agregar menu a plato en BLL ");
                throw;
            }
        }

        public int EditarMenu(int idMenu, string nombre, string precio, DateTime? fechaBaja)
        {
            try
            {
                return _menuBLL.EditarMenu(idMenu, nombre, obtenerPrecio(precio), fechaBaja);

            }
            catch (ArgumentException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al editar menu a plato en BLL ");
                throw;
            }
        }

        public string PlatoDuplicado(int idPlato, List<Plato> listaPlatos)
        {
            int mismoPlato = 0;
            foreach (var plato in listaPlatos)
            {
                if (plato.IdPlato == idPlato)
                {
                    mismoPlato++;
                }
            }

            if (mismoPlato >= 1)
            {
                return "No se puede duplicar el plato en el menú";
            }
            return null;
        }

        public int AgregarPlatoMenu(int idMenu, int idPlato)
        {
            try
            {
                return _menuBLL.AgregarPlatoMenu(idMenu, idPlato);
            }
            catch (ArgumentException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al agregar menu a plato en DAL ");
                throw;
            }
        }

        public int EliminarPlatoMenu(int idMenu, int idPlato)
        {
            try
            {
                return _menuBLL.EliminarPlatoMenu(idMenu, idPlato);
            }
            catch (ArgumentException ex)
            {
                logger.Error(ex, "Error al agregar menu a plato en DAL ");
                throw;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al agregar menu a plato en DAL ");
                throw;
            }
        }
    }
}

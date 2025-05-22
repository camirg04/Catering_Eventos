using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Catering;

namespace DTO_Catering
{
    public class AlertaStockDTO
    {
        private int _idAlertaStock;
        private int _idInsumo;
        private string _nombreInsumo;
        private string _estadoAlerta;
        private DateTime? _fechaAlerta;
        public AlertaStockDTO() { }
        public AlertaStockDTO(int idAlertaStock, int idInsumo, string nombreInsumo, string estadoAlerta, DateTime? fechaAlerta)
        {
            _idAlertaStock = idAlertaStock;
            _idInsumo = idInsumo;
            _nombreInsumo = nombreInsumo;
            _estadoAlerta = estadoAlerta;
            _fechaAlerta = fechaAlerta;
        }

        public int IdAlertaStock
        {
            get { return _idAlertaStock; }
            set { _idAlertaStock = value; }
        }

        public int IdInsumo
        {
            get { return _idInsumo; }
            set { _idInsumo = value; }
        }

        [DisplayName("Nombre")]
        public string NombreInsumo
        {
            get { return _nombreInsumo; }
            set { _nombreInsumo = value; }
        }
        [DisplayName("Estado")]
        public string EstadoAlerta
        {
            get { return _estadoAlerta; }
            set { _estadoAlerta = value; }
        }
        [DisplayName("Fecha")]
        public DateTime? FechaAlerta
        {
            get { return _fechaAlerta; }
            set { _fechaAlerta = value; }
        }


        public static AlertaStockDTO mapAlertaStockToAlertaStockDTO(AlertaStock alerta)
        {
            return new AlertaStockDTO(alerta.IdAlertaStock,alerta.Insumo.IdInsumo, alerta.Insumo.Nombre,alerta.EstadoAlerta,alerta.FechaAlerta);
        }

        public static List<AlertaStockDTO> mapListAlertaStockToListAlertaStockDTO(List<AlertaStock> listaAlertas)
        {
            List<AlertaStockDTO> listaAlertasDTO = new List<AlertaStockDTO>();
            foreach (var alerta in listaAlertas)
            {
                listaAlertasDTO.Add(mapAlertaStockToAlertaStockDTO(alerta));
            }
            return listaAlertasDTO;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Catering
{
    public class AlertaStock
    {
        private int _idAlertaStock;
        private Insumo _insumo;
        private string _estadoAlerta;
        private DateTime? _fechaAlerta;

        public AlertaStock() { }

        public AlertaStock(int idAlertaStock, Insumo insumo, string estadoAlerta, DateTime? fechaAlerta)
        {
            _idAlertaStock = idAlertaStock;
            _insumo = insumo;
            _estadoAlerta = estadoAlerta;
            _fechaAlerta = fechaAlerta;
        }

        public int IdAlertaStock
        {
            get { return _idAlertaStock; }
            set { _idAlertaStock = value; }
        }

        public Insumo Insumo
        {
            get { return _insumo; }
            set { _insumo = value; }
        }

        public string EstadoAlerta { get { return _estadoAlerta; } set { _estadoAlerta = value; } }

        public DateTime? FechaAlerta
        {
            get { return _fechaAlerta; }
            set { _fechaAlerta = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Catering
{
    public class LoteInsumo
    {
        private int _idLoteInsumo;
        private Insumo _insumo;
        private PedidoInsumo _pedidoInsumo;
        private Decimal _cantidad;
        private Decimal _costoUnitario;
        private DateTime _fechaIngreso;
        private DateTime? _fechaVencimiento;

        public LoteInsumo() { }

        public LoteInsumo(int idLoteInsumo, Insumo insumo, PedidoInsumo pedidoInsumo, Decimal cantidad, Decimal costoUnitario, DateTime fechaIngreso, DateTime? fechaVencimiento)
        {
            _idLoteInsumo = idLoteInsumo;
            _insumo = insumo;
            _pedidoInsumo = pedidoInsumo;
            _cantidad = cantidad;
            _costoUnitario = costoUnitario;
            _fechaIngreso = fechaIngreso;
            _fechaVencimiento = fechaVencimiento;
        }

        public int IDLoteInsumo
        {
            get { return _idLoteInsumo; }
            set { _idLoteInsumo = value; }
        }

        public Insumo Insumo
        {
            get { return _insumo; }
            set { _insumo = value; }
        }

        public PedidoInsumo PedidoInsumo
        {
            get { return _pedidoInsumo; }
            set { _pedidoInsumo = value; }
        }

        public Decimal Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public Decimal CostoUnitario
        {
            get { return _costoUnitario; }
            set { _costoUnitario = value; }
        }

        public DateTime FechaIngreso
        {
            get { return _fechaIngreso; }
            set { _fechaIngreso = value; }
        }

        public DateTime? FechaVencimiento
        {
            get { return _fechaVencimiento; }
            set { _fechaVencimiento = value; }
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Catering
{
    public class Insumo
    {
        private int _idInsumo;
        private string _nombre;
        private string _unidadMedida;
        private bool _perecedero;
        private Decimal _stockMinimo;
        private DateTime? _fechaBaja;


        public Insumo() { }

        public Insumo(int idInsumo, string nombre, string unidadMedida, bool perecedero, Decimal stockMinimo, DateTime? fechaBaja)
        {
            _idInsumo = idInsumo;
            _nombre = nombre;
            _unidadMedida = unidadMedida;
            _perecedero = perecedero;
            _stockMinimo = stockMinimo;
            _fechaBaja = fechaBaja;
        }

        public int IdInsumo
        {
            get { return _idInsumo; }
            set { _idInsumo = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string UnidadMedida
        {
            get { return _unidadMedida; }
            set { _unidadMedida = value; }
        }
        public bool Perecedero
        {
            get { return _perecedero; }
            set { _perecedero = value; }
        }
        public Decimal StockMinimo
        {
            get { return _stockMinimo; }
            set { _stockMinimo = value; }
        }
        public DateTime? FechaBaja
        {
            get { return _fechaBaja; }
            set { _fechaBaja = value; }
        }
    }
}

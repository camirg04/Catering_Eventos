using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private string _esPerecedero;
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
       
        public bool Perecedero
        {
            get { return _perecedero; }
            set { 
                _perecedero = value;
                _esPerecedero = value ? "Si" : "No";
            }
        }

        [DisplayName("Perecedero")]
        public string EsPerecedero
        {
            get { return _esPerecedero; }
            set {
                
                _esPerecedero = value;
                _perecedero = value.Equals("Si", StringComparison.OrdinalIgnoreCase);
            }
        }

        [DisplayName("Stock mínimo")]
        public Decimal StockMinimo
        {
            get { return _stockMinimo; }
            set { _stockMinimo = value; }
        }

        [DisplayName("Unidad de medida")]
        public string UnidadMedida
        {
            get { return _unidadMedida; }
            set { _unidadMedida = value; }
        }

        [DisplayName("Fecha de baja")]
        public DateTime? FechaBaja
        {
            get { return _fechaBaja; }
            set { _fechaBaja = value; }
        }
    }
}

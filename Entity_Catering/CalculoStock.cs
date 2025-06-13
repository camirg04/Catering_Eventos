using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Catering
{
    public class CalculoStock
    {
        private int _idIngrediente;
        private string _ingrediente;
        private Decimal _cantidadNecesaria;
        private Decimal _stockMinimo;
        private Decimal _stock;
        private string _mensaje;
        private string _unidadMedida;

        public CalculoStock()
        {

        }

        public int IdIngrediente { get => _idIngrediente; set => _idIngrediente = value; }
        public string Ingrediente { get => _ingrediente; set => _ingrediente = value; }
        public decimal CantidadNecesaria { get => _cantidadNecesaria; set => _cantidadNecesaria = value; }
        public decimal StockMinimo { get => _stockMinimo; set => _stockMinimo = value; }
        public decimal Stock { get => _stock; set => _stock = value; }
        public string Mensaje { get => _mensaje; set => _mensaje = value; }
        public string UnidadMedida { get => _unidadMedida; set => _unidadMedida = value; }
    }
}

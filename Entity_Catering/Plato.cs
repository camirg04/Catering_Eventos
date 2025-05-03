using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Catering
{
    public class Plato
    {
        private int _idPlato;
        private string _nombre;
        private string _tipoPlato;
        private DateTime? _fechaBaja;
        // falta agregar lista de ingredientes y sus cantidades

        public Plato() { }

        public Plato(int idPlato, string nombre, string tipoPlato, DateTime? fechaBaja)
        {
            _idPlato = idPlato;
            _nombre = nombre;
            _tipoPlato = tipoPlato;
            _fechaBaja = fechaBaja;
        }


        public int IdPlato
        {
            get { return _idPlato; }
            set { _idPlato = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string TipoPlato
        {
            get { return _tipoPlato; }
            set { _tipoPlato = value; }
        }

        public DateTime? FechaBaja
        {
            get { return _fechaBaja; }
            set { _fechaBaja = value; }
        }
    }
}

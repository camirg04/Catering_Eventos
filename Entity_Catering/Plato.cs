using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private List<PlatoInsumo> _listaInsumos; // lista de insumos que componen el plato
        // falta agregar lista de ingredientes y sus cantidades

        public Plato() {

        }

        public Plato(int idPlato, string nombre, string tipoPlato, DateTime? fechaBaja)
        {
            _idPlato = idPlato;
            _nombre = nombre;
            _tipoPlato = tipoPlato;
            _fechaBaja = fechaBaja;
        }

        [DisplayName("ID Plato")]
        public int IdPlato
        {
            get { return _idPlato; }
            set { _idPlato = value; }
        }

        [DisplayName("Nombre")]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        [DisplayName("Tipo de plato")]
        public string TipoPlato
        {
            get { return _tipoPlato; }
            set { _tipoPlato = value; }
        }

        [DisplayName("Fecha de baja")]
        public DateTime? FechaBaja
        {
            get { return _fechaBaja; }
            set { _fechaBaja = value; }
        }

        public List<PlatoInsumo> ListaInsumos
        {
            get { return _listaInsumos; }
            set { _listaInsumos = value; }
        }
    }
}

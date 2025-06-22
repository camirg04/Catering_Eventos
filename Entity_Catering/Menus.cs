using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;


namespace Entity_Catering
{
    public class Menus
    {

        private int _idMenu;
        private string _nombre;
        private Decimal _precioPorPersona;
        private DateTime? _fechaBaja;
        private List<Plato> _platos;

        public Menus()
        {
            _platos = new List<Plato>();
        }

        public Menus(string nombre, Decimal precioPorPersona)
        {
            Nombre = nombre;
            PrecioPorPersona = precioPorPersona;
            _platos = new List<Plato>();
        }
        public Menus(string nombre, Decimal precioPorPersona, int idMenu)
        {
            Nombre = nombre;
            PrecioPorPersona = precioPorPersona;
            IdMenu = idMenu;
            _platos = new List<Plato>();
        }

        public Menus(string nombre, Decimal precioPorPersona, int idMenu, DateTime fechaBaja)
        {
            Nombre = nombre;
            PrecioPorPersona = precioPorPersona;
            IdMenu = idMenu;
            FechaDeBaja = fechaBaja;
            _platos = new List<Plato>();
        }

        public int IdMenu
        {
            get { return _idMenu; }
            set { _idMenu = value; }
        }

     
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        [DisplayName("Precio por persona")]
        public Decimal PrecioPorPersona
        {
            get { return _precioPorPersona; }
            set { _precioPorPersona = value; }
        }


        [DisplayName("Fecha de baja")]
        public DateTime? FechaDeBaja
        {
            get { return _fechaBaja; }
            set { _fechaBaja = value; }
        }

        public List<Plato> Platos
        {
            get { return _platos; }
            set { _platos = value; }
        }



    }
}

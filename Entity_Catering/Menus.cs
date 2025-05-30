using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace Entity_Catering
{
    public class Menus
    {
        private int _idMenu;
        private string _nombre;
        private float _precioPorPersona;
        private List<Plato> _platos = new List<Plato>();
        private DateTime? _fechaBaja;

        public Menus()
        {
            _platos = new List<Plato>();
        }

        public Menus(string nombre, float precioPorPersona)
        {
            Nombre = nombre;
            PrecioPorPersona = precioPorPersona;
            _platos = new List<Plato>();

        }
        public Menus(string nombre, float precioPorPersona, int idMenu)
        {
            Nombre = nombre;
            PrecioPorPersona = precioPorPersona;
            IdMenu = idMenu;
            _platos = new List<Plato>();
        }

        public Menus(string nombre, float precioPorPersona, int idMenu, DateTime fechaBaja, List<Plato> platos)
        {
            Nombre = nombre;
            PrecioPorPersona = precioPorPersona;
            IdMenu = idMenu;
            FechaDeBaja = fechaBaja;
            Platos = platos;
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
        public float PrecioPorPersona
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

        public List<Plato> Platos { get => _platos; set => _platos = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;


namespace Entity_Catering
{
    public class Menu
    {

        private int _idMenu;
        private string _nombre;
        private float _precioPorPersona;
        private DateTime _fechaBaja;

        public Menu()
        {

        }

        public Menu(string nombre, float precioPorPersona)
        {
            Nombre = nombre;
            PrecioPorPersona = precioPorPersona;

        }
        public Menu(string nombre, float precioPorPersona, int idMenu)
        {
            Nombre = nombre;
            PrecioPorPersona = precioPorPersona;
            IdMenu = idMenu;

        }

        public Menu(string nombre, float precioPorPersona, int idMenu, DateTime fechaBaja)
        {
            Nombre = nombre;
            PrecioPorPersona = precioPorPersona;
            IdMenu = idMenu;
            FechaDeBaja = fechaBaja;

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


        public float PrecioPorPersona
        {
            get { return _precioPorPersona; }
            set { _precioPorPersona = value; }
        }

  

        public DateTime FechaDeBaja
        {
            get { return _fechaBaja; }
            set { _fechaBaja = value; }
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Catering
{
    public class Empleado
    {

        private int _idEmpleado;
        private string _dni;
        private string _nombre;
        private string _apellido;
        private string _domicilio;
        private string _telefono;
        private DateTime? _fechaBajaEmpleado;

        // Propiedades públicas
        public int IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }

        public string DNI
        {
            get { return _dni; }
            set
            {
                _dni = value;
            }
        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
            }
        }

        public string Apellido
        {
            get { return _apellido; }
            set
            {
                _apellido = value;
            }
        }

        public string Domicilio
        {
            get { return _domicilio; }
            set
            {
                _domicilio = value;
            }
        }

        public string Telefono
        {
            get { return _telefono; }
            set
            {
                _telefono = value;
            }
        }

        public DateTime? FechaBajaEmpleado
        {
            get { return _fechaBajaEmpleado; }
            set { _fechaBajaEmpleado = value; }
        }

        // Propiedad calculada
        public string NombreCompleto => $"{Nombre} {Apellido}";

        // Constructores
        public Empleado()
        {
        }

        public Empleado(int idEmpleado, string dniEmpleado, string nombre, string apellido, string domicilio, string telefono)
        {
            IdEmpleado = idEmpleado;
            DNI = dniEmpleado;
            Nombre = nombre;
            Apellido = apellido;
            Domicilio = domicilio;
            Telefono = telefono;
        }

        // Métodos
        public bool EmpleadoActivo()
        {
            return !FechaBajaEmpleado.HasValue;
        }

        public override string ToString()
        {
            return $"{NombreCompleto} (DNI: {DNI})";
        }

    }
}

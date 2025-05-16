using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Catering
{
    public class Usuario
    {
        private int _idUsuario;
        private string _mail;
        private string _clave;
        private string _perfil;
        private string _email;
        private string _dni;
        private string _nombre;
        private string _apellido;
        private string _domicilio;
        private string _telefono;
        private DateTime? _fechaCreacion;
        private DateTime? _fechaBajaUsuario;

        // Propiedades públicas
        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public string Mail
        {
            get { return _mail; }
            set
            {
                _mail = value;
            }
        }

        public string Clave
        {
            get { return _clave; }
            set
            {
                _clave = value;
            }
        }

        public string Perfil
        {
            get { return _perfil; }
            set
            {
                _perfil = value;
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
            }
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

        public DateTime? FechaCreacion
        {
            get { return _fechaCreacion; }
            set
            {
                _fechaCreacion = value;
            }
        }

        public DateTime? FechaBajaUsuario
        {
            get { return _fechaBajaUsuario; }
            set
            {
                _fechaBajaUsuario = value;
            }
        }

        // Constructor

        public Usuario()
        {
        }

        public Usuario(int idUsuario, string mail, string clave, string perfil, string email, DateTime? fechaCreacion, DateTime? fechaBajaUsuario, string dniEmpleado, string nombre, string apellido, string domicilio, string telefono)
        {
            _idUsuario = idUsuario;
            _mail = mail;
            _clave = clave;
            _perfil = perfil;
            _email = email;
            _fechaCreacion = fechaCreacion;
            _fechaBajaUsuario = fechaBajaUsuario;
            _dni = dniEmpleado;
            _nombre = nombre;
            _apellido = apellido;
            _domicilio = domicilio;
            _telefono = telefono;
        }


        public bool UsuarioActivo()
        {
            return !FechaBajaUsuario.HasValue;
        }

    }
}

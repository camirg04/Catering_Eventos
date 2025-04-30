using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Catering
{
    public class Usuario : Empleado
    {
        private int _idUsuario;
        private string _mail;
        private string _clave;
        private string _perfil;
        private string _email;
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

        public Usuario(int idUsuario, string mail, string clave, string perfil, string email, DateTime? fechaCreacion, DateTime? fechaBajaUsuario)
        {
            _idUsuario = idUsuario;
            _mail = mail;
            _clave = clave;
            _perfil = perfil;
            _email = email;
            _fechaCreacion = fechaCreacion;
            _fechaBajaUsuario = fechaBajaUsuario;
        }


        public bool UsuarioActivo()
        {
            return !FechaBajaUsuario.HasValue;
        }

    }
}

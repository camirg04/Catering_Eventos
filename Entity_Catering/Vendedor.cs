using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Catering
{
    public class Vendedor : Usuario
    {
        public Vendedor() { }
        public Vendedor(Usuario usuario)
        {
            IdUsuario = usuario.IdUsuario;
            Mail = usuario.Mail;
            Clave = usuario.Clave;
            Perfil = usuario.Perfil;
            Email = usuario.Email;
            FechaCreacion = usuario.FechaCreacion;
            DNI = usuario.DNI;
            Nombre = usuario.Nombre;
            FechaBajaUsuario = usuario.FechaBajaUsuario;
            Apellido = usuario.Apellido;
            Domicilio = usuario.Domicilio;
            Telefono = usuario.Telefono;
        }
    }
}

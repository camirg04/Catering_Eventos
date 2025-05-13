using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Catering
{
	public class Cliente
	{

		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private string _apellido;

		public string Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}

		private string _direccion;

		public string Direccion
		{
			get { return _direccion; }
			set { _direccion = value; }
		}

		private string _email;

		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}

		private string _dni;

		public string DNI
		{
			get { return _dni; }
			set { _dni = value; }
		}


		private string _telefono;

		public string Telefono
		{
			get { return _telefono; }
			set { _telefono = value; }
		}
		private int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}



		public Cliente()
		{

		}

		//para crear un cliente nuevo en la bd, se usa este constructor:
		public Cliente(string nombre, string apellido, string email, string telefono, string domicilio, string dni)
		{
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Telefono = telefono;
            Direccion = domicilio;
            DNI = dni;

        }

        //para traer clientes de la bd, se usara este constructor:

        public Cliente(int idCliente, string nombre, string apellido, string email, string telefono, string domicilio, string dni)
        {
			Id = idCliente;
			Nombre = nombre;
			Apellido = apellido;		
			Email = email;	
			Telefono = telefono;
			Direccion = domicilio;
			DNI = dni;

        }
		





    }
}

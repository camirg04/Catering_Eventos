using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Catering
{
	public class Evento
	{

		private DateTime _fecha;

		public DateTime Fecha
		{
			get { return _fecha; }
			set { _fecha = value; }
		}


		private float _descuentoAplicado;

		public float DescuentoAplicado
		{
			get { return _descuentoAplicado; }
			set { _descuentoAplicado = value; }
		}

		private string _direccion;

		public  string Direccion
		{
			get { return _direccion; }
			set { _direccion = value; }
		}

		private string _localidad;

		public  string Localidad
		{
			get { return _localidad; }
			set { _localidad = value; }
		}

		private int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _estado;

		public string Estado
		{
			get { return _estado; }
			set { _estado = value; }
		}

		private int _cantidadPersonas;

		public int CantidadPersonas
		{
			get { return _cantidadPersonas; }
			set { _cantidadPersonas = value; }
		}

		private float _totalEstimado;

		public float Total
		{
			get { return _totalEstimado; }
			set { _totalEstimado = value; }
		}

		private int _pago;

		public int Pago
		{
			get { return _pago; }
			set { _pago = value; }
		}

		private int _idUsuarioVenta;

		public int IdUsuarioVenta
		{
			get { return _idUsuarioVenta; }
			set { _idUsuarioVenta = value; }
		}

		private int _idMenu;

		public int IdMenu
		{
			get { return _idMenu; }
			set { _idMenu = value; }
		}

		private int _idCliente;

		public int IdCliente
		{
			get { return _idCliente; }
			set { _idCliente = value; }
		}


		//para construir el objeto desde la bd
		public Evento(DateTime fecha, float descuentoAplicado, string direccion, string localidad, string estado, int cantidadPersonas, float totalEstimado, int pago, int id_usuario_venta, int idMenu, int idCliente, int idEvento)
		{
			Id = idEvento;
            Fecha = fecha;
            DescuentoAplicado = descuentoAplicado;
            Direccion = direccion;
            Localidad = localidad;
            Estado = estado;
            CantidadPersonas = cantidadPersonas;
            Total = totalEstimado;
            Pago = pago;
            IdUsuarioVenta = id_usuario_venta;
            IdMenu = idMenu;
            IdCliente = idCliente;
        }
        //para construir un objeto nuevo

        public Evento(DateTime fecha, float descuentoAplicado, string direccion, string localidad, string estado, int cantidadPersonas, float totalEstimado, int pago, int id_usuario_venta, int idMenu, int idCliente)
        {

            Fecha = fecha;
            DescuentoAplicado = descuentoAplicado;
            Direccion = direccion;
            Localidad = localidad;
            Estado = estado;
            CantidadPersonas = cantidadPersonas;
			Total = totalEstimado;
			Pago = pago;
			IdUsuarioVenta = id_usuario_venta;
			IdMenu = idMenu;
			IdCliente = idCliente;

        }

        public Evento()
		{

		}





	}
}
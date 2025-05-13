using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Catering;
using Entity_Catering;

namespace Servicio_Catering
{
    public partial class UIGerente : Form
    {
        private readonly EmpleadosBLL _empleadosBLL;
        private readonly MenusBLL _menusBLL;
        private readonly EventosBLL _eventosBLL;
        public UIGerente()
        {
            InitializeComponent();
            _empleadosBLL = new EmpleadosBLL();
            _menusBLL = new MenusBLL();
            _eventosBLL = new EventosBLL();
        }

        private void obtenerEmpleados()
        {
            try
            {

                List<Entity_Catering.Empleado> empleados = _empleadosBLL.ListarEmpleados();

                dgvVisualiza.DataSource = empleados;
                dgvVisualiza.Columns["FechaBajaEmpleado"].Visible = false;
                dgvVisualiza.Columns["NombreCompleto"].Visible = false;


            }
            catch (Exception es)
            {

                throw es;
            }
        }

        private void obtenerMenus()
        {
            try
            {

                List<Entity_Catering.Menus> menus = _menusBLL.ListarMenus();
                dgvVisualizaProductos.DataSource = menus;
                dgvVisualizaProductos.Columns["FechaDeBaja"].Visible = false;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void obtenerTodasLasVentas()
        {
            try
            {
                List<Entity_Catering.Evento> eventos = _eventosBLL.ListarEventos();
                dgvVisualizaReporte.DataSource = eventos;



            }
            catch (Exception)
            {

                throw;
            }
        }



        private void btnTodoEmpleados_Click(object sender, EventArgs e)
        {
            obtenerEmpleados();

        }

        private void UIGerente_Load(object sender, EventArgs e)
        {
            obtenerTodasLasVentas();

        }

        private void btnMenus_Click(object sender, EventArgs e)
        {
            obtenerMenus();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

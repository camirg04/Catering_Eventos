using BLL_Catering;
using Entity_Catering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Servicio_Catering
{
    public partial class UIVendedor : Form
    {
        private Usuario Vendedor;
        private List<Menus> MenusVende = new List<Menus>();
        private List<Cliente> ClienteVende = new List<Cliente>();
        private List<Evento> eventosLista = new List<Evento>();
        private MenusBLL _menu = new MenusBLL();
        private ClienteBLL _cliente = new ClienteBLL();
        private EventosBLL _evento = new EventosBLL();
        public UIVendedor(Usuario user)
        {
            InitializeComponent();
            Vendedor = user;
            eventosLista.AddRange(_evento.ListarEventos());
        }


        private void UIVendedor_Load(object sender, EventArgs e)
        {
            /*PANTALLA CARGA EVENTO*/
            gb_crea_evento.Visible = false;
            gb_mod_evento.Visible = false;
            gb_crear_cliente.Visible = false;
            gb_mod_cliente.Visible = false;
            /*PANTALLA CARGA EVENTO*/
        }

        /*INICI PANTALLA EVENTO*/
        private void cotizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                /*PANTALLA CREAR EVENTO*/
                gb_crea_evento.Visible = true;
                gb_mod_evento.Visible = false;
                textBox23.Text = Vendedor.IdUsuario.ToString();
                int cantidad = eventosLista[eventosLista.Count() - 1].Id;
                textBox16.Text = (cantidad + 1).ToString();
                comboBox6.SelectedIndex = -1;


                /*COMBO BOX CLIENTES*/
                ClienteVende.Clear();
                ClienteVende.AddRange(_cliente.ListarClientes());
                this.comboBox4.DataSource = ClienteVende.ToList();
                this.comboBox4.DisplayMember = "Nombre";
                this.comboBox4.ValueMember = "Id";
                this.comboBox4.SelectedIndex = -1;

                /*COMBO BOX MENUS*/
                MenusVende.Clear();
                MenusVende.AddRange(_menu.ListarMenus());
                this.comboBox3.DataSource = MenusVende.ToList();
                this.comboBox3.DisplayMember = "Nombre";
                this.comboBox3.ValueMember = "IdMenu";
                this.comboBox3.SelectedIndex = -1;
                /*PANTALLA CREAR EVENTO*/
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        /*INICIA PANTALLA MUESTRA CREAR CLIENTE*/
        private void crearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gb_crear_cliente.Visible = true;
            gb_mod_cliente.Visible = false;
        }

        /*INICIA PANTALLA MODIFICAR EVENTO*/
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gb_crea_evento.Visible = false;
            gb_mod_evento.Visible = true;
            /*CARGAMOS GRID*/
            eventosLista.Clear();
            eventosLista.AddRange(_evento.ListarEventos());
            dataGridView2.DataSource = eventosLista.ToList();
            dataGridView2.Columns["Id"].Visible = false;
            dataGridView2.Columns["IdUsuarioVenta"].Visible = false;
            dataGridView2.Columns["IdMenu"].Visible = false;
            dataGridView2.Columns["IdCliente"].Visible = false;

            comboBox4.SelectedIndex = -1;
            /*COMBO BOX MENUS*/
            MenusVende.Clear();
            MenusVende.AddRange(_menu.ListarMenus());
            this.comboBox5.DataSource = MenusVende.ToList();
            this.comboBox5.DisplayMember = "Nombre";
            this.comboBox5.ValueMember = "IdMenu";
            this.comboBox5.SelectedIndex = -1;
            /*COMBO BOX CLIENTES*/
            ClienteVende.Clear();
            ClienteVende.AddRange(_cliente.ListarClientes());
            this.comboBox6.DataSource = ClienteVende.ToList();
            this.comboBox6.DisplayMember = "Nombre";
            this.comboBox6.ValueMember = "Id";
            this.comboBox6.SelectedIndex = -1;
            /*PANTALLA MODIFICAR EVENTO*/

            /*AGREGAMOS NUEVA COLUMNA*/
            dataGridView2.Columns.Add("Menu", "Menu");
            dataGridView2.Columns.Add("Cliente", "Cliente");

            // un bucle suicida pero rellena, la proxima mas que un DTO o esta cosa fea, es mejor tener una vista de sql que haga inner join o right
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                foreach (Cliente cliente in ClienteVende)
                {
                    if (cliente.Id == int.Parse(row.Cells["IdCliente"].Value.ToString()))
                    {
                        row.Cells["Cliente"].Value = cliente.Nombre;
                    }
                }

                foreach (Menus menu in MenusVende)
                {
                    if (menu.IdMenu == int.Parse(row.Cells["IdMenu"].Value.ToString()))
                    {
                        row.Cells["Menu"].Value = menu.Nombre;
                    }
                }
            }
            //cambiamos orden
            dataGridView2.Columns["Cliente"].DisplayIndex = 0;
            dataGridView2.Columns["Menu"].DisplayIndex = 1;
            /*AGREGAMOS NUEVA COLUMNA*/
        }

        // COMIENZA CLIENTES

        // INICIA PANTALLA CLIENTE
        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gb_crear_cliente.Visible = false;
            gb_mod_cliente.Visible = true;
            ClienteVende.Clear();
            ClienteVende.AddRange(_cliente.ListarClientes());
            dataGridView1.DataSource = ClienteVende.ToList();
            dataGridView1.Columns["Id"].Visible = false;
        }

        /*BOTON CREAR CLIENTE*/

        private void btnCrearC_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteBLL clienteBLL = new ClienteBLL();
                Cliente cliente = new Cliente(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox10.Text, textBox6.Text);
                clienteBLL.AddCliente(cliente);
                MessageBox.Show("Se creo el cliente");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox10.Text = "";
                textBox6.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*BOTON CREAR CLIENTE*/

        /*EVENTO GRID PARA CARGAR LOS CLIENTES Y PODER MODIFICARLOS*/
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    Evento eventoRelleno = new Evento();
                    //eventoRelleno = dataGridView2.Rows[e.RowIndex].Cells["Id"].Value as Evento;
                    //nombre        apellido        email         telefono      domi            dni 
                    //textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox10.Text, textBox6.Text

                    textBox12.Text = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                    textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                    textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                    textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                    textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells["DNI"].Value.ToString();
                    textBox13.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
        /*EVENTO GRID PARA CARGAR LOS CLIENTES Y PODER MODIFICARLOS*/

        /*BOTON GUARDAR CLIENTE MODIFICADO*/

        private void button3_Click(object sender, EventArgs e)
        {
            //int idCliente, string nombre, string apellido, string email, string telefono, string domicilio, string dni
            try
            {
                Cliente clienteUpdate = new Cliente(int.Parse(textBox13.Text.ToString()), textBox12.Text, textBox11.Text, textBox9.Text,
                    textBox8.Text, textBox5.Text, textBox7.Text);
                //ClienteBLL clienteBLL = new ClienteBLL();
                _cliente.UpdateCliente(clienteUpdate);
                var index = ClienteVende.FindIndex(ele => ele.Id == clienteUpdate.Id);

                if (index != -1)
                {
                   ClienteVende[index] = clienteUpdate;
                }

                dataGridView1.DataSource = ClienteVende.ToList();
                
                textBox13.Text = "";
                textBox12.Text = "";
                textBox11.Text = "";
                textBox9.Text = "";
                textBox8.Text = "";
                textBox5.Text = "";
                textBox7.Text = "";
                MessageBox.Show("Se actualizaron los cambios");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*BOTON GUARDAR CLIENTE MODIFICADO*/

        //FIN CODIGO CLIENTE

        //COMIENZA CODIGO EVENTO

        /*EVENTO BOX SOBRE CALCULO DE % DE BENIFICIO*/
        private void textBox22_Leave(object sender, EventArgs e)
        {
            try
            {
                string cantidad = textBox22.Text.ToString();
                int menuId = -1;
                if (comboBox3.SelectedIndex != -1)
                {
                    menuId = int.Parse(comboBox3.SelectedValue.ToString());
                }
                Decimal precioMenu = 0;
                int porcentaje = 0;
                if ((cantidad != "" || cantidad != null) && menuId != -1)
                {
                    foreach (Menus menuItem in MenusVende)
                    {
                        if (menuItem.IdMenu == menuId)
                        {
                            precioMenu = menuItem.PrecioPorPersona;

                        }
                    }
                    //calcula %
                    porcentaje = devuelvePorcentaje(int.Parse(cantidad.ToString()));
                    textBox24.Text = porcentaje.ToString();
                    textBox21.Text = calculaTotal(porcentaje, int.Parse(cantidad.ToString()), precioMenu).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*EVENTO BOX SOBRE CALCULO DE % DE BENIFICIO*/

        /*FUNCION QUE EVALUA EL PORCENTAJE SEGUN CANTIDAD DE PERSONAS Y CANTIDAD DE COMPRAS REALIZADAS*/

        private int devuelvePorcentaje(int cantidad)
        {
            int clienteId = -1;
            List<Evento> eventosByCliente = new List<Evento>();
            int porcentaje=0;
            /*VEMOS QUE COMBO REALIZA EL CAMBIO*/
            if (comboBox4.SelectedIndex != -1)
            {
                clienteId = int.Parse(comboBox4.SelectedValue.ToString());
                eventosByCliente = _evento.GetEventoByIdCliente(clienteId);
            }
            if (comboBox6.SelectedIndex != -1)
            {
                clienteId = int.Parse(comboBox6.SelectedValue.ToString());
                eventosByCliente = _evento.GetEventoByIdCliente(clienteId);
            }
            /*VEMOS SI TIENE MAS DE 3 EVENTOS*/
            if (eventosByCliente.Count >= 3)
            {
                porcentaje = 5;
            }
            /*VEMOS LA CANTIDAD DE PERSONAS*/
            if (cantidad >= 200 )
            {
                return porcentaje + 10;

            }
            else if (cantidad >= 100)
            {
                return porcentaje + 5;
            }
            else
            {
                return porcentaje;
            }

        }
        /*FUNCION QUE EVALUA EL PORCENTAJE SEGUN CANTIDAD DE PERSONAS Y CANTIDAD DE COMPRAS REALIZADAS*/

        /*FUNCION DE CALCULO DEL TOTAL*/
        private double calculaTotal(int porcentaje, int cantidad, Decimal precioMenu)
        {
            if (porcentaje>100)
            {
                throw new Exception("El porcentaje no puede valer mas de 100");
            }
            double precio = (double)precioMenu;
            return (cantidad * precio - ((cantidad * precio) * (porcentaje / 100.0)));
        }
        /*FUNCION DE CALCULO DEL TOTAL*/

        /*EVENTO COMBO PARA CALCULAR EL TOTAL Y LOS DECUENTOS SEGUN MENU*/
        private void comboBox3_Leave(object sender, EventArgs e)
        {
            try
            {
                string cantidad = textBox22.Text.ToString();
                int menuId = -1;
                if (comboBox3.SelectedIndex != -1)
                {
                    menuId = int.Parse(comboBox3.SelectedValue.ToString());
                }
                Decimal precioMenu = 0;
                int porcentaje = 0;
                if ((cantidad != "" || cantidad != null) && menuId != -1)
                {
                    foreach (Menus menuItem in MenusVende)
                    {
                        if (menuItem.IdMenu == menuId)
                        {
                            precioMenu = menuItem.PrecioPorPersona;

                        }
                    }
                    //calcula %
                    porcentaje = devuelvePorcentaje(int.Parse(cantidad.ToString()));
                    textBox24.Text = porcentaje.ToString();
                    textBox21.Text = calculaTotal(porcentaje, int.Parse(cantidad.ToString()), precioMenu).ToString();
                }
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }
        /*EVENTO COMBO PARA CALCULAR EL TOTAL Y LOS DECUENTOS SEGUN MENU*/

        /*EVENTO BOX PARA CALCULAR EL TOTAL Y LOS DECUENTOS SEGUN % BENEFICIO*/

        private void textBox24_Leave(object sender, EventArgs e)
        {
            try
            {
                string cantidad = textBox22.Text.ToString();
                int menuId = -1;
                if (comboBox3.SelectedIndex != -1)
                {
                    menuId = int.Parse(comboBox3.SelectedValue.ToString());
                }
                Decimal precioMenu = 0;
                int porcentaje = 0;
                if ((cantidad != "" || cantidad != null) && menuId != -1)
                {
                    foreach (Menus menuItem in MenusVende)
                    {
                        if (menuItem.IdMenu == menuId)
                        {
                            precioMenu = menuItem.PrecioPorPersona;

                        }
                    }
                    //calcula %
                    if (textBox24.Text != "" || textBox24.Text != null)
                    {
                        porcentaje = int.Parse(textBox24.Text);
                    }
                    else
                    {
                        porcentaje = devuelvePorcentaje(int.Parse(cantidad.ToString()));
                    }
                    textBox24.Text = porcentaje.ToString();
                    textBox21.Text = calculaTotal(porcentaje, int.Parse(cantidad.ToString()), precioMenu).ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox24.Text = "";
                textBox21.Text = "";
            }
        }
        /*EVENTO BOX PARA CALCULAR EL TOTAL Y LOS DECUENTOS SEGUN % BENEFICIO*/

        /*EVENTO COMBO PARA CALCULAR EL TOTAL Y LOS DECUENTOS SEGUN CLIENTE*/
        private void comboBox4_Leave(object sender, EventArgs e)
        {
            //textBox24.Leave += comboBox4_Leave;
            int porcentaje = 0;
            string cantidad = textBox22.Text.ToString();
            Decimal precioMenu = 0;
            if (comboBox3.SelectedIndex != -1 && textBox24.Text != "")
            {
                int menuId = -1;
                if (comboBox3.SelectedIndex != -1)
                {
                    menuId = int.Parse(comboBox3.SelectedValue.ToString());
                }
                foreach (Menus menuItem in MenusVende)
                {
                    if (menuItem.IdMenu == menuId)
                    {
                        precioMenu = menuItem.PrecioPorPersona;

                    }
                }
                porcentaje = devuelvePorcentaje(int.Parse(cantidad.ToString()));
                textBox24.Text = porcentaje.ToString();
                textBox21.Text = calculaTotal(porcentaje, int.Parse(cantidad.ToString()), precioMenu).ToString();

            }
        }
        /*EVENTO COMBO PARA CALCULAR EL TOTAL Y LOS DECUENTOS SEGUN CLIENTE*/


        //PARTE DE MODIFICAR EVENTO 


        /*EVENTO BOX PARA CALCULAR EL TOTAL Y LOS DECUENTOS SEGUN CANTIDAD DE PERSONAS*/
        private void textBox27_Leave(object sender, EventArgs e)
        {
            try
            {
                string cantidad = textBox27.Text.ToString();
                int menuId = -1;
                if (comboBox5.SelectedIndex != -1)
                {
                    menuId = int.Parse(comboBox5.SelectedValue.ToString());
                }
                Decimal precioMenu = 0;
                int porcentaje = 0;
                if ((cantidad != "" || cantidad != null) && menuId != -1)
                {
                    foreach (Menus menuItem in MenusVende)
                    {
                        if (menuItem.IdMenu == menuId)
                        {
                            precioMenu = menuItem.PrecioPorPersona;

                        }
                    }
                    //calcula %
                    porcentaje = devuelvePorcentaje(int.Parse(cantidad.ToString()));
                    textBox25.Text = porcentaje.ToString();
                    textBox28.Text = calculaTotal(porcentaje, int.Parse(cantidad.ToString()), precioMenu).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /*EVENTO BOX PARA CALCULAR EL TOTAL Y LOS DECUENTOS SEGUN CANTIDAD DE PERSONAS*/

        /*EVENTO COMBO PARA CALCULAR EL TOTAL Y LOS DECUENTOS SEGUN MENU*/
        private void comboBox5_Leave(object sender, EventArgs e)
        {
            try
            {
                string cantidad = textBox27.Text.ToString();
                int menuId = -1;
                if (comboBox5.SelectedIndex != -1)
                {
                    menuId = int.Parse(comboBox5.SelectedValue.ToString());
                }
                Decimal precioMenu = 0;
                int porcentaje = 0;
                if ((cantidad != "" || cantidad != null) && menuId != -1)
                {
                    foreach (Menus menuItem in MenusVende)
                    {
                        if (menuItem.IdMenu == menuId)
                        {
                            precioMenu = menuItem.PrecioPorPersona;

                        }
                    }
                    //calcula %
                    porcentaje = devuelvePorcentaje(int.Parse(cantidad.ToString()));
                    textBox25.Text = porcentaje.ToString();
                    textBox28.Text = calculaTotal(porcentaje, int.Parse(cantidad.ToString()), precioMenu).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /*EVENTO COMBO PARA CALCULAR EL TOTAL Y LOS DECUENTOS SEGUN MENU*/

        /*EVENTO BOX PARA CALCULAR EL TOTAL Y LOS DECUENTOS SEGUN % BENEFICIO*/

        private void textBox25_Leave(object sender, EventArgs e)
        {
            Console.WriteLine("EJECUTO EL LEAVE  DE TEXTBOX25");
            try
            {
                string cantidad = textBox27.Text.ToString();
                int menuId = -1;
                if (comboBox5.SelectedIndex != -1)
                {
                    menuId = int.Parse(comboBox5.SelectedValue.ToString());
                }
                Decimal precioMenu = 0;
                int porcentaje = 0;
                if ((cantidad != "" || cantidad != null) && menuId != -1)
                {
                    foreach (Menus menuItem in MenusVende)
                    {
                        if (menuItem.IdMenu == menuId)
                        {
                            precioMenu = menuItem.PrecioPorPersona;

                        }
                    }
                    //calcula %
                    if (textBox25.Text != "" || textBox25.Text != null)
                    {
                        porcentaje = int.Parse(textBox25.Text);
                    }
                    else
                    {
                        porcentaje = devuelvePorcentaje(int.Parse(cantidad.ToString()));
                    }
                    textBox25.Text = porcentaje.ToString();
                    textBox28.Text = calculaTotal(porcentaje, int.Parse(cantidad.ToString()), precioMenu).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox25.Text = "";
                textBox28.Text = "";
            }
        }
        /*EVENTO BOX PARA CALCULAR EL TOTAL Y LOS DECUENTOS SEGUN % BENEFICIO*/

        /*EVENTO COMBO PARA CALCULAR EL TOTAL Y LOS DECUENTOS SEGUN CLIENTE*/

        private void comboBox6_Leave(object sender, EventArgs e)
        {
            int porcentaje = 0;
            string cantidad = textBox27.Text.ToString();
            Decimal precioMenu = 0;
            if (comboBox5.SelectedIndex != -1 && textBox27.Text != "")
            {
                int menuId = -1;
                if (comboBox5.SelectedIndex != -1)
                {
                    menuId = int.Parse(comboBox5.SelectedValue.ToString());
                }
                foreach (Menus menuItem in MenusVende)
                {
                    if (menuItem.IdMenu == menuId)
                    {
                        precioMenu = menuItem.PrecioPorPersona;

                    }
                }
                porcentaje = devuelvePorcentaje(int.Parse(cantidad.ToString()));
                textBox25.Text = porcentaje.ToString();
                textBox28.Text = calculaTotal(porcentaje, int.Parse(cantidad.ToString()), precioMenu).ToString();

            }
        }

        /*EVENTO COMBO PARA CALCULAR EL TOTAL Y LOS DECUENTOS SEGUN CLIENTE*/

        /*BOTON CREAMOS EVENTO*/
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(comboBox1.SelectedIndex.ToString());
                if (comboBox1.SelectedIndex == -1)
                {
                    throw new Exception("Tiene que selecciona un valor de si paga el cliente");
                }

                Evento evento = new Evento(DateTime.Parse(dateTimePicker1.Text), float.Parse(textBox24.Text), textBox17.Text, textBox20.Text, "PENDIENTE", int.Parse(textBox22.Text), float.Parse(textBox21.Text), comboBox1.SelectedIndex, int.Parse(textBox23.Text), int.Parse(this.comboBox3.SelectedValue.ToString()), int.Parse(this.comboBox4.SelectedValue.ToString()));
                _evento.AddEvento(evento);
                evento.Id = int.Parse(textBox16.Text.ToString());
                eventosLista.Add(evento);
                MessageBox.Show("Evento generado");
                textBox24.Text = "";
                textBox17.Text = "";
                textBox20.Text = "";
                textBox22.Text = "";
                textBox21.Text = "";
                comboBox1.Text = "";
                this.comboBox3.SelectedIndex = -1;
                this.comboBox4.SelectedIndex = -1;
                textBox16.Text = (int.Parse(textBox16.Text.ToString()) + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en guardar los datos: "+ex.Message);
            }
        }
        /*BOTON CREAMOS EVENTO*/

        /*COMBO CARGAMOS LOS DATOS DEL CLIENTE CUANDO CAMBIA EL BOX DEL CLIENTE*/
        private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (Cliente clienteOne in ClienteVende)
            {
                if (clienteOne.Id == int.Parse(this.comboBox4.SelectedValue.ToString()))
                {
                    this.textBox17.Text = clienteOne.Direccion.ToString();
                }
            }

        }
        /*EVENTO GRID PARA CARGAR LOS EVENTOS Y PODER MODIFICARLOS*/
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    //Evento eventoRelleno = new Evento();

                    //int idEvento, DateTime fecha,  string direccion, string localidad, string estado, float totalEstimado, int cantidadPersonas,  int descuentoAplicado, int pago, int id_usuario_venta, int idMenu, int idCliente
                    this.comboBox5.SelectedValue = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["IdMenu"].Value.ToString());
                    this.comboBox6.SelectedValue = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["IdCliente"].Value.ToString());
                    this.comboBox2.SelectedIndex = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["Pago"].Value.ToString());
                    this.comboBox7.SelectedIndex = dataGridView2.Rows[e.RowIndex].Cells["Estado"].Value.ToString() == "PENDIENTE" ? 0 : 1;

                    textBox33.Text = dataGridView2.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    dateTimePicker2.Text = dataGridView2.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
                    textBox26.Text = dataGridView2.Rows[e.RowIndex].Cells["IdUsuarioVenta"].Value.ToString();
                    textBox27.Text = dataGridView2.Rows[e.RowIndex].Cells["CantidadPersonas"].Value.ToString();
                    textBox32.Text = dataGridView2.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                    textBox29.Text = dataGridView2.Rows[e.RowIndex].Cells["Localidad"].Value.ToString();
                    textBox25.Text = dataGridView2.Rows[e.RowIndex].Cells["DescuentoAplicado"].Value.ToString();
                    textBox28.Text = dataGridView2.Rows[e.RowIndex].Cells["Total"].Value.ToString();

                    button2.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
        /*EVENTO GRID PARA CARGAR LOS EVENTOS Y PODER MODIFICARLOS*/


        /*BOTON GUARDA EVENTO MODIFICADO*/
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Evento evento = new Evento(DateTime.Parse(dateTimePicker2.Text), float.Parse(textBox25.Text), textBox32.Text, textBox29.Text, comboBox7.Text, int.Parse(textBox27.Text), float.Parse(textBox28.Text),
                comboBox2.SelectedIndex, int.Parse(textBox26.Text), int.Parse(this.comboBox5.SelectedValue.ToString()), int.Parse(this.comboBox6.SelectedValue.ToString()));
                evento.Id = int.Parse(textBox33.Text.ToString());

                EventosBLL updateEvento = new EventosBLL();
                updateEvento.UpdateEvento(evento);
                var indexEvento = eventosLista.FindIndex(w => w.Id == evento.Id);
                if (indexEvento != -1)
                {
                    eventosLista[indexEvento] = evento;
                    dataGridView2.DataSource = eventosLista.ToList();
                }
                MessageBox.Show("Se actualizaron los cambios");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            textBox33.Text = "";
            dateTimePicker2.Value = DateTime.Today;
            textBox26.Text = "";
            textBox27.Text = "";
            textBox32.Text = "";
            textBox29.Text = "";
            textBox28.Text = "";
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            textBox25.Text = "";
            button2.Enabled = false;

        }


        /*BOTON GUARDA EVENTO MODIFICADO*/

    }
}

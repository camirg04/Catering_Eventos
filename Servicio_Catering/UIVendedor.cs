using BLL_Catering;
using Entity_Catering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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
        private List<Evento> eventos1 = new List<Evento>();

        public UIVendedor(Usuario user)
        {
            InitializeComponent();

            Vendedor = user;

            BLL_Catering.MenusBLL Menu = new MenusBLL();
            BLL_Catering.ClienteBLL cliente = new ClienteBLL();
            EventosBLL eventos = new EventosBLL();



            MenusVende.AddRange(Menu.ListarMenus());
            this.comboBox3.DataSource = MenusVende.ToList();
            this.comboBox3.DisplayMember = "Nombre";
            this.comboBox3.ValueMember = "IdMenu";
            this.comboBox3.SelectedIndex = -1;

            this.comboBox5.DataSource = MenusVende.ToList();
            this.comboBox5.DisplayMember = "Nombre";
            this.comboBox5.ValueMember = "IdMenu";
            this.comboBox5.SelectedIndex = -1;

            ClienteVende.AddRange(cliente.ListarClientes());
            this.comboBox4.DataSource = ClienteVende.ToList();
            this.comboBox4.DisplayMember = "Nombre";
            this.comboBox4.ValueMember = "Id";
            this.comboBox4.SelectedIndex = -1;

            this.comboBox6.DataSource = ClienteVende.ToList();
            this.comboBox6.DisplayMember = "Nombre";
            this.comboBox6.ValueMember = "Id";
            this.comboBox6.SelectedIndex = -1;



            eventos1.AddRange(eventos.ListarEventos());

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void UIVendedor_Load(object sender, EventArgs e)
        {
            gb_crea_evento.Visible = false;
            gb_mod_evento.Visible = false;
            gb_crear_cliente.Visible = false;
            gb_mod_cliente.Visible = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cotizarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void moToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cotizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gb_crea_evento.Visible = true;
            gb_mod_evento.Visible = false;
            textBox23.Text = Vendedor.IdUsuario.ToString();
            int cantidad = eventos1[eventos1.Count()-1].Id;

            textBox16.Text = (cantidad + 1).ToString();
            comboBox6.SelectedIndex = -1;


            /* try
             {
                 EventosBLL eventos = new EventosBLL();
                 List<Evento> eventos1 = eventos.ListarEventos();

                 int cantidad = eventos1.Count;
                 gb_crea_evento.Visible = true;
                 gb_mod_evento.Visible = false;
                 textBox23.Text = Vendedor.IdUsuario.ToString();
                 textBox16.Text = (cantidad + 1).ToString();
             }
             catch (Exception ex) { 
                 MessageBox.Show(ex.Message);
             }*/
        }

        private void crearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gb_crear_cliente.Visible = true;
            gb_mod_cliente.Visible = false;
        }

        private void nuevoEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gb_crea_evento.Visible = false;
            gb_mod_evento.Visible = true;
            dataGridView2.DataSource = eventos1.ToList();
            comboBox4.SelectedIndex = -1;
            //EventosBLL eventoguardar = new EventosBLL();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gb_crear_cliente.Visible = false;
            gb_mod_cliente.Visible = true;
            dataGridView1.DataSource = ClienteVende.ToList();
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox33_LostFocus(object sender, EventArgs e)
        {
            //EventosBLL eventosObtener = new EventosBLL();

            //List<Evento> evento = eventosObtener.OneEvento(Int32.Parse(textBox33.Text));
            ////MessageBox.Show(evento[0].Fecha.ToString());
            //if (evento.Count != 0)
            //{

            //}
            //else
            //{
            //    MessageBox.Show("Evento no encontrado");
            //}

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox33_Leave(object sender, EventArgs e)
        {
            /*EventosBLL eventosObtener = new EventosBLL();

            try
            {
                List<Evento> evento = eventosObtener.OneEvento(Int32.Parse(textBox33.Text));
                if (evento.Count != 0)
                {
                    textBox25.Text = evento[0].Id.ToString();
                    textBox26.Text = evento[0].IdUsuarioVenta.ToString();
                    textBox27.Text = evento[0].CantidadPersonas.ToString();
                    textBox28.Text = evento[0].Total.ToString();
                    textBox29.Text = evento[0].Localidad.ToString();
                    textBox30.Text = evento[0].IdMenu.ToString();
                    textBox31.Text = evento[0].IdCliente.ToString();
                    textBox32.Text = evento[0].Direccion.ToString();
                    //comboBox2.SelectedIndex = evento[0].Pago;
                    dateTimePicker2.Value = DateTime.Parse(evento[0].Fecha.ToString());
                }
                else
                {
                    MessageBox.Show("Evento no encontrado");
                }
            }
            catch (Exception ex)
            { 
            
                    MessageBox.Show(ex.Message);

            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {

            EventosBLL eventoguardar = new EventosBLL();

            try
            {
                Evento evento = new Evento(DateTime.Parse(dateTimePicker1.Text), float.Parse(textBox24.Text), textBox17.Text, textBox20.Text, "PENDIENTE", int.Parse(textBox22.Text), float.Parse(textBox21.Text), comboBox1.Text == "si" ? 1 : 0, int.Parse(textBox23.Text), int.Parse(this.comboBox3.SelectedValue.ToString()), int.Parse(this.comboBox4.SelectedValue.ToString()));
                eventoguardar.AddEvento(evento);
                //(cantidad + 1).ToString()
                evento.Id = int.Parse(textBox16.Text.ToString());
                eventos1.Add(evento);
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
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Hubo un error en guardar los datos");
            }



            /*EventosBLL eventoguardar = new EventosBLL();
            //int idEvento, DateTime fecha,  string direccion, string localidad, string estado, float totalEstimado, int cantidadPersonas,  int descuentoAplicado, int pago, int id_usuario_venta, int idMenu, int idCliente
            try
            {
                Evento evento = new Evento(DateTime.Parse(dateTimePicker1.Text), float.Parse(textBox24.Text), textBox17.Text, textBox17.Text, "PENDIENTE", int.Parse(textBox22.Text), float.Parse(textBox21.Text), comboBox1.Text == "SI" ? 1 : 0, int.Parse(textBox23.Text), int.Parse(textBox19.Text), int.Parse(textBox18.Text));
                eventoguardar.AddEvento(evento);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Hubo un error en guardar los datos");
            }*/
        }

        private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //MessageBox.Show(this.comboBox4.SelectedValue.ToString());
            foreach(Cliente clienteOne in ClienteVende)
            {
                if (clienteOne.Id == int.Parse(this.comboBox4.SelectedValue.ToString()))
                {
                    this.textBox17.Text = clienteOne.Direccion.ToString();
                }
            }
            
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //MessageBox.Show(this.comboBox3.SelectedValue.ToString());

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 )
                {
                    Evento eventoRelleno = new Evento();
                    //eventoRelleno = dataGridView2.Rows[e.RowIndex].Cells["Id"].Value as Evento;


                    //int idEvento, DateTime fecha,  string direccion, string localidad, string estado, float totalEstimado, int cantidadPersonas,  int descuentoAplicado, int pago, int id_usuario_venta, int idMenu, int idCliente
                    this.comboBox5.SelectedValue = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["IdMenu"].Value.ToString());
                    this.comboBox6.SelectedValue = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["IdCliente"].Value.ToString());
                    this.comboBox2.SelectedIndex = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["Pago"].Value.ToString());

                    textBox33.Text = dataGridView2.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    dateTimePicker2.Text = dataGridView2.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
                    textBox26.Text = dataGridView2.Rows[e.RowIndex].Cells["IdUsuarioVenta"].Value.ToString();
                    textBox27.Text = dataGridView2.Rows[e.RowIndex].Cells["CantidadPersonas"].Value.ToString();
                    textBox32.Text = dataGridView2.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                    textBox29.Text = dataGridView2.Rows[e.RowIndex].Cells["Localidad"].Value.ToString();
                    textBox25.Text = dataGridView2.Rows[e.RowIndex].Cells["DescuentoAplicado"].Value.ToString();
                    textBox28.Text = dataGridView2.Rows[e.RowIndex].Cells["Total"].Value.ToString();


                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Evento evento = new Evento(DateTime.Parse(dateTimePicker2.Text), float.Parse(textBox25.Text), textBox32.Text, textBox29.Text, "PENDIENTE", int.Parse(textBox27.Text), float.Parse(textBox28.Text),
                comboBox2.Text == "si" ? 1 : 0, int.Parse(textBox26.Text), int.Parse(this.comboBox5.SelectedValue.ToString()), int.Parse(this.comboBox6.SelectedValue.ToString()));
                evento.Id = int.Parse(textBox33.Text.ToString());

                EventosBLL updateEvento = new EventosBLL();
                updateEvento.UpdateEvento(evento);
                MessageBox.Show("Se actualizaron los cambios");


                textBox33.Text = "";
                dateTimePicker2.Value = DateTime.Today;
                textBox26.Text = "";
                textBox27.Text = "";
                textBox32.Text = "";
                textBox29.Text = "";
                textBox25.Text = "";
                textBox28.Text = "";
                comboBox5.SelectedIndex = -1;
                comboBox6.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;

                var indexEvento = eventos1.FindIndex(w => w.Id == evento.Id);
                if (indexEvento != -1)
                {
                    eventos1[indexEvento] = evento;
                }
                dataGridView2.DataSource = eventos1.ToList();


                //eventoOneUpdat


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }


        }

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

        private void button3_Click(object sender, EventArgs e)
        {
            //int idCliente, string nombre, string apellido, string email, string telefono, string domicilio, string dni
           

            try
            {
                Cliente clienteUpdate = new Cliente(int.Parse(textBox13.Text.ToString()), textBox12.Text, textBox11.Text, textBox9.Text,
                    textBox8.Text, textBox5.Text, textBox7.Text);
                ClienteBLL clienteBLL = new ClienteBLL();
                clienteBLL.UpdateCliente(clienteUpdate);
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

        private void gb_mod_cliente_Enter(object sender, EventArgs e)
        {

        }
       

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
                float precioMenu = 0;
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
        private int devuelvePorcentaje(int cantidad)
        {
            int clienteId = -1;
            List<Evento> eventosByCliente = new List<Evento>();
            EventosBLL eventosByClienteBll = new EventosBLL();
            int porcentaje=0;
            if (comboBox4.SelectedIndex != -1)
            {
                clienteId = int.Parse(comboBox4.SelectedValue.ToString());
                eventosByCliente = eventosByClienteBll.GetEventoByIdCliente(clienteId);
            }
            if (comboBox6.SelectedIndex != -1)
            {
                clienteId = int.Parse(comboBox6.SelectedValue.ToString());
                eventosByCliente = eventosByClienteBll.GetEventoByIdCliente(clienteId);
            }

            if (eventosByCliente.Count >= 3)
            {
                porcentaje = 5;
            }

            Console.WriteLine(cantidad);
            Console.WriteLine(eventosByCliente.Count);

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

        private double calculaTotal(int porcentaje, int cantidad, double precioMenu)
        {
            if (porcentaje>100)
            {
                throw new Exception("El porcentaje no puede valer mas de 100");
            }
            return (cantidad*precioMenu - ((cantidad * precioMenu) * (porcentaje / 100f)));
        }

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
                float precioMenu = 0;
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
                float precioMenu = 0;
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

        private void comboBox4_Leave(object sender, EventArgs e)
        {
            //textBox24.Leave += comboBox4_Leave;
            int porcentaje = 0;
            string cantidad = textBox22.Text.ToString();
            double precioMenu = 0;
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

        //PARTE DE MODIFICAR EVENTO 
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
                float precioMenu = 0;
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
                float precioMenu = 0;
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

        private void textBox25_Leave(object sender, EventArgs e)
        {
            try
            {
                string cantidad = textBox27.Text.ToString();
                int menuId = -1;
                if (comboBox5.SelectedIndex != -1)
                {
                    menuId = int.Parse(comboBox5.SelectedValue.ToString());
                }
                float precioMenu = 0;
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

        private void comboBox6_Leave(object sender, EventArgs e)
        {
            int porcentaje = 0;
            string cantidad = textBox27.Text.ToString();
            double precioMenu = 0;
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
    }
}

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
        public UIVendedor(Usuario user)
        {
            InitializeComponent();
            Vendedor = user;
            //Usuario usuarioVendedor = new Usuario(user);
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
            try
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
            }
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
            ClienteBLL clientes = new ClienteBLL();
            dataGridView1.DataSource = clientes.ListarClientes();
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
            EventosBLL eventosObtener = new EventosBLL();

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

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventosBLL eventoguardar = new EventosBLL();
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
            }
        }
    }
}

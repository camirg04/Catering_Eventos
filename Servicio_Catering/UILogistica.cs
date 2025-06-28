using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Catering;
using DTO_Catering;
using Entity_Catering;

namespace Servicio_Catering
{
    public partial class UILogistica : Form, PerfilUsuario
    {
        private Usuario _usuario;
        private List<LoteInsumoDTO> _lote = new List<LoteInsumoDTO>();
        private List<Insumo> _insumo = new List<Insumo>();
        private List<PedidoInsumo> _pedido= new List<PedidoInsumo>();
        public UILogistica(Usuario user)
        {
            InitializeComponent();
            _usuario = user;
            //instancio blllote para trearme todos los lotes
            LoteInsumoBLL loteInsumoBLL = new LoteInsumoBLL();
            _lote.AddRange(loteInsumoBLL.ObtenerLotesInsumos());
            dataGridView2.DataSource = _lote.ToList();
            dataGridView2.Columns["Severidad"].Visible = false;
            //me traigo todos los insumos
            InsumoBLL insumoBll = new InsumoBLL();
            _insumo.AddRange(insumoBll.ObtenerInsumosActivos());
            this.comboBox1.DataSource = _insumo.ToList();
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.ValueMember = "IdInsumo";
            this.comboBox1.SelectedIndex = -1;
            //inicializamos data grid de PEDIDO INSUMO
            PedidoInsumoBLL pedidoBLL = new PedidoInsumoBLL();

            _pedido.AddRange(pedidoBLL.ObtenerPedidoInsumoBLL());
            //_pedido[0].Insumo.IdInsumo
            dataGridView1.DataSource = _pedido.ToList();
            dataGridView1.Columns["Insumo"].Visible = false;
            dataGridView1.Columns["UsuarioPedido"].Visible = false;
            this.comboBox2.DataSource = _insumo.ToList();
            this.comboBox2.DisplayMember = "Nombre";
            this.comboBox2.ValueMember = "IdInsumo";
            this.comboBox2.SelectedIndex = -1;
            this.comboBox7.DataSource = _insumo.ToList();
            this.comboBox7.DisplayMember = "Nombre";
            this.comboBox7.ValueMember = "IdInsumo";
            this.comboBox7.SelectedIndex = -1;

            this.comboBox4.DataSource = _insumo.ToList();
            this.comboBox4.DisplayMember = "Nombre";
            this.comboBox4.ValueMember = "IdInsumo";
            this.comboBox4.SelectedIndex = -1;
        }


        public string darBienvenida(string nombre)
        {
            return "¡Bienvenido/a " + nombre + "!";
        }

        public void cerrarSesion()
        {
            this.Close();
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            cerrarSesion();
        }

        private void UILogistica_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = darBienvenida(_usuario.Nombre);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
        /*EVENTOS  PARA STOCK*/
        private void button4_Click(object sender, EventArgs e)
        {
            string idInsumo = this.comboBox1.SelectedValue.ToString();
            string fechaIngresoInicio = this.dateTimePicker2.Text;
            string fechaIngresoFin = this.dateTimePicker1.Text;

            if (idInsumo == "")
            {
                MessageBox.Show("Tiene que tener un producto");
            }
            else
            {
                LoteInsumoBLL loteInsumoBLL = new LoteInsumoBLL();
                Console.WriteLine(loteInsumoBLL.BuscarLotePorId(int.Parse(idInsumo), fechaIngresoInicio, fechaIngresoFin).Count);
                _lote.Clear();
                _lote.AddRange(loteInsumoBLL.BuscarLotePorId(int.Parse(idInsumo), fechaIngresoInicio, fechaIngresoFin));
                dataGridView2.DataSource = _lote.ToList();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            LoteInsumoBLL loteInsumoBLL = new LoteInsumoBLL();
            _lote.Clear();
            _lote.AddRange(loteInsumoBLL.ObtenerLotesInsumos());
            dataGridView2.DataSource = _lote.ToList();
            dataGridView2.Columns["Severidad"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
                {
                    //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

                    if (dataGridView1.Rows[e.RowIndex].Cells["EstadoPedido"].Value.ToString() != "ENTREGADO")
                    {
                        //vemos el campo estadoPedido
                        if (dataGridView1.Rows[e.RowIndex].Cells["EstadoPedido"].Value.ToString() == "ENTREGADO")
                        {
                            comboBox6.SelectedIndex = 1;
                        }
                        else
                        {
                            comboBox6.SelectedIndex = 0;
                        }
                        //sacamos la cantidad
                        textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString();
                        //sacamos la fecha del pedido
                        dateTimePicker6.Text = dataGridView1.Rows[e.RowIndex].Cells["FechaPedido"].Value.ToString();
                        //creo un insumo que esta en el campo INSUMO
                        Insumo OneInsumo = new Insumo();
                        OneInsumo = dataGridView1.Rows[e.RowIndex].Cells["Insumo"].Value as Insumo;
                        //matcheo el id con el value -- idInsumo
                        comboBox7.SelectedValue = OneInsumo.IdInsumo;
                        textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["IdPedidoInsumo"].Value.ToString();
                        //creo un usuario
                        Usuario OneUsuario = new Usuario();
                        OneUsuario = dataGridView1.Rows[e.RowIndex].Cells["UsuarioPedido"].Value as Usuario;
                        textBox4.Text = OneUsuario.IdUsuario.ToString();
                    }
                    else
                    {
                        MessageBox.Show("El Insumo ya fue entregado");
                    }
                    

                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox7.SelectedValue.ToString());
            //int idInsumo = int.Parse(comboBox7.SelectedValue.ToString());
            //int idPedidoInsumo = int.Parse(textBox3.Text.ToString());
            //DateTime fechaPedidoInsumo = dateTimePicker6.Value;
            //string entregado = comboBox6.Text;
            //int idUsuario = int.Parse(textBox4.Text.ToString());
            PedidoInsumoBLL updatePedido = new PedidoInsumoBLL();

            if (comboBox7.SelectedValue.ToString() != "" && textBox3.Text.ToString() != "" && comboBox6.Text != "" && textBox4.Text.ToString() != "")
            {

                int idInsumo = int.Parse(comboBox7.SelectedValue.ToString());
                int idPedidoInsumo = int.Parse(textBox3.Text.ToString());
                DateTime fechaPedidoInsumo = dateTimePicker6.Value;
                string entregado = comboBox6.Text;
                Decimal cantidad = Decimal.Parse(textBox2.Text.ToString());
                //Insumo OneInsumo = new Insumo();
                
                //foreach (var item in _insumo)
                //{
                //    if (item.IdInsumo == int.Parse(comboBox7.SelectedValue.ToString()))
                //    {
                //        OneInsumo = item;
                //    }
                //}
                //decimal precioUnitario = OneInsumo.

                 updatePedido.UpdatePedidoInsumoBLL(idInsumo, idPedidoInsumo, fechaPedidoInsumo, entregado, cantidad,0);

                PedidoInsumoBLL pedidoBLL = new PedidoInsumoBLL();
                _pedido.Clear();
                _pedido.AddRange(pedidoBLL.ObtenerPedidoInsumoBLL());
                //_pedido[0].Insumo.IdInsumo

                dataGridView1.DataSource = _pedido.ToList();
                dataGridView1.Columns["Insumo"].Visible = false;
                dataGridView1.Columns["UsuarioPedido"].Visible = false;

                MessageBox.Show("Datos actualizados");
                comboBox7.SelectedIndex = -1;
                textBox3.Text = "";
                dateTimePicker6.Value = DateTime.Now;
                comboBox6.SelectedIndex = -1;
                textBox2.Text = "";
                textBox4.Text = "";

            }
            else
            {
                MessageBox.Show("Falta Datos Llenar");
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            DateTime fecha_pedido = dateTimePicker5.Value;
            decimal cantidad = decimal.Parse(textBox1.Text);
            string estado = comboBox5.Text;
            int idInsumo = int.Parse(comboBox4.SelectedValue.ToString());
            int idUsuario = _usuario.IdUsuario;
            int idPedidoInsumo = dataGridView1.Rows.Count;

            if ((comboBox4.SelectedValue.ToString() != "" || idInsumo != -1) && textBox1.Text.ToString() != "" && comboBox5.Text != "")
            {
                idPedidoInsumo++;
                PedidoInsumoBLL pedidoInsumo = new PedidoInsumoBLL();
                pedidoInsumo.AddPedidoInsumoBll(idPedidoInsumo, idInsumo, fecha_pedido, estado, cantidad, idUsuario);
                dateTimePicker5.Value = DateTime.Now;
                textBox1.Text = "";
                comboBox4.SelectedIndex= -1;
                comboBox5.SelectedIndex= -1;
            }
            else
            {
                MessageBox.Show("Tiene que tener todos los campos llenos");
            }

                
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex != -1)
                {
                    if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
                    {
                        //text 5 -> insumo
                        //text6 -> unidad medida
                        //text7 -> cantidad ->
                        //text8 -> costo unit
                        //datetime 7 -> fechavence
                        decimal cantidad = decimal.Parse(dataGridView2.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());//decimal.Parse(textBox5.Text);
                        DateTime fecha_vence = DateTime.Parse(dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString());
                        string insumo = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                        string idPedidoInsumo = dataGridView2.Rows[e.RowIndex].Cells["idLoteInsumo"].Value.ToString();
                        string unidad = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                        decimal costo = decimal.Parse(dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString());

                        textBox5.Text = insumo;
                        textBox6.Text = unidad;
                        textBox7.Text = cantidad.ToString();
                        textBox8.Text = costo.ToString();
                        textBox9.Text  = idPedidoInsumo.ToString();
                        dateTimePicker7.Value = fecha_vence;
                    }
                }

            }
            catch(Exception ex) {  MessageBox.Show(ex.Message); }

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox9.Text != "")
                {
                    int idLote = int.Parse(textBox9.Text);
                    decimal costo = Decimal.Parse(textBox8.Text);
                    DateTime vence = dateTimePicker7.Value;
                    LoteInsumoBLL loteBll = new LoteInsumoBLL();
                    loteBll.ActualizarCostoFechaLote(idLote, costo, vence);

                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    dateTimePicker7.Value = DateTime.Now;
                    MessageBox.Show("Los datos se actualizaron");

                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        /*EVENTOS  PARA STOCK*/


    }
}

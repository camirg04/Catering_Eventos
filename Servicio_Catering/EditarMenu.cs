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
using NLog;
using Entity_Catering;
using System.Globalization;

namespace Servicio_Catering
{
    public partial class EditarMenu : Form
    {
        private Menus _menu;
        private readonly ChefBLL _chefBLL;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly HelperFront _helperFront;
        private string _modo;
        private List<Plato> _listaPlatos;

        public EditarMenu(Menus menu, string modo)
        {
            _menu = menu;
            _modo = modo;
            _chefBLL = new ChefBLL();
            _helperFront = new HelperFront();
            InitializeComponent();
        }

        private void tabIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabIngredientes.SelectedTab == tabPage2 && _modo != "editar")
            {
                MessageBox.Show("Debe crear el menú para agregar platos");
            }
        }

        private void cargarDgvPlatos(List<Plato> platos)
        {
            dgvPlatos.ReadOnly = true;
            dgvPlatos.DataSource = null;
            dgvPlatos.DataSource = platos;
            dgvPlatos.Columns["IdPlato"].Visible = false;
        }

        private void preseleccionarDatos()
        {
            tbNombreMenu.Text = _menu.Nombre;
            tbPrecioxpersona.Text = _menu.PrecioPorPersona.ToString();
            if (_menu.FechaDeBaja == null)
            {
                cbMenuActivo.SelectedIndex = cbMenuActivo.FindStringExact("Si");
                lbFechaBaja.Text = "-";
            }
            else
            {
                cbMenuActivo.SelectedIndex = cbMenuActivo.FindStringExact("No");
                lbFechaBaja.Text = _menu.FechaDeBaja.ToString();
            }
        }

        private void visibilidadBotonesMenuEditar()
        {
            tbNombreMenu.Enabled = true;
            tbPrecioxpersona.Enabled = true;
            cbMenuActivo.Enabled = true;
            btnGuardarMenu.Visible = true;
            btnEditarMenu.Visible = false;
        }

        private void visibilidadBotonesMenuVer()
        {
            tbNombreMenu.Enabled = false;
            tbPrecioxpersona.Enabled = false;
            cbMenuActivo.Enabled = false;
            btnGuardarMenu.Visible = false;
            btnEditarMenu.Visible = true;
        }

        private void visibilidadBotonesPlatosAgregar()
        {
            cbPlatos.Visible = false;
            lblPlato.Visible = false;
            btnAgregarPlato.Visible = false;
            btnEliminarPlato.Visible = false;
            btnEditarPlatos.Visible = false;
            dgvPlatos.Visible = false;
        }
        private void visibilidadBotonesPlatosEditar()
        {
            cbPlatos.Visible = true;
            lblPlato.Visible = true;
            btnAgregarPlato.Visible = true;
            btnEliminarPlato.Visible = true;
            btnEditarPlatos.Visible = false;
            dgvPlatos.Visible = true;
        }

        private void visibilidadBotonesPlatosVer()
        {
            cbPlatos.Visible = false;
            lblPlato.Visible = false;
            btnAgregarPlato.Visible = false;
            btnEliminarPlato.Visible = false;
            btnEditarPlatos.Visible = true;
            dgvPlatos.Visible = true;
        }

        private void EditarMenu_Load(object sender, EventArgs e)
        {
            try
            {
                _helperFront.cargarComboSiNo(cbMenuActivo);
                _listaPlatos = _chefBLL.BuscarPlatos(null,null,"Si");
                _helperFront.cargarComboPlatos(cbPlatos, _listaPlatos);
        
                if (_modo == "agregar")
                {
                    lbFechaBaja.Text = "-";   
                    visibilidadBotonesPlatosAgregar();
                    visibilidadBotonesMenuEditar();
                }
                else
                {
                    preseleccionarDatos();
                    visibilidadBotonesMenuVer();
                    visibilidadBotonesPlatosVer();
                }
                cargarDgvPlatos(_menu.Platos);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar los datos del plato en UI");
                MessageBox.Show("Error al cargar los datos del plato");

            }
        }

        private void btnEditarMenu_Click(object sender, EventArgs e)
        {
            visibilidadBotonesMenuEditar();
        }

        private void btnEditarPlatos_Click(object sender, EventArgs e)
        {
            visibilidadBotonesPlatosEditar();
        }


        private void btnGuardarMenu_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreMenu = tbNombreMenu.Text;
                string precioPorPersona = tbPrecioxpersona.Text;
                DateTime? fechaBaja = cbMenuActivo.Text == "Si" || cbMenuActivo.Text == "" ? null : (DateTime?)DateTime.Now;

                int exito;
                if (_modo == "editar")
                    exito = _chefBLL.EditarMenu(_menu.IdMenu,nombreMenu,precioPorPersona,fechaBaja);
                else
                    exito = _chefBLL.CrearMenu(nombreMenu,precioPorPersona,fechaBaja);
                    if(exito > 0)
                        _menu.IdMenu = exito;


                if (exito > 0)
                {
                    _menu.Nombre = nombreMenu;
                    _menu.PrecioPorPersona = Convert.ToDecimal(precioPorPersona);
                    _menu.FechaDeBaja = fechaBaja;
                    MessageBox.Show("Se guardaron los cambios");
                    if (_modo == "agregar")
                    {
                        _modo = "editar";
                        visibilidadBotonesPlatosEditar();
                    }
                }
                else
                {
                    MessageBox.Show("No se pudieron guardar los cambios, intentelo nuevamente mas tarde");
                    this.Close();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                logger.Error(ex, "Error de validación al agregar menu");
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al guardar los cambios del menu, intentelo nuevamente mas tarde");
                this.Close();
            }
        }

        private void cbMenuActivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbMenuActivo.Text == "Si")
                {
                    lbFechaBaja.Text = "-";
                }
                else if (cbMenuActivo.Text == "No")
                {
                    if (_menu.FechaDeBaja == null)
                    {
                        lbFechaBaja.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        lbFechaBaja.Text = _menu.FechaDeBaja.ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cambiar el estado del plato");
                MessageBox.Show("Error al cambiar el estado del plato");
            }
        }

        private void btnAgregarPlato_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevoPlato = (Plato)cbPlatos.SelectedItem;

                int exito = _chefBLL.AgregarPlatoMenu(_menu.IdMenu, (int)cbPlatos.SelectedValue);
                if (exito > 0)
                    _menu.Platos.Add(nuevoPlato);

                cargarDgvPlatos(_menu.Platos);

            }
            catch (ArgumentException ex)
            {
                logger.Error(ex, "Error de validación al agregar plato al menú");
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                logger.Error("No se pudo agregar el plato al menú, intentelo nuevamente mas tarde");
            }
        }

        private void btnEliminarPlato_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevoPlato = (Plato)cbPlatos.SelectedItem;

                int exito = _chefBLL.EliminarPlatoMenu(_menu.IdMenu, (int)cbPlatos.SelectedValue);
                if (exito > 0)
                    nuevoPlato = _menu.Platos.Find(p => p.IdPlato == nuevoPlato.IdPlato);
                    _menu.Platos.Remove(nuevoPlato);

                cargarDgvPlatos(_menu.Platos);

            }
            catch (ArgumentException ex)
            {
                logger.Error(ex, "Error de validación al eliminar plato al menú");
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                logger.Error("No se pudo eliminar el plato al menú, intentelo nuevamente mas tarde");
            }
        }

        private void dgvPlatos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPlatos.CurrentRow == null)
                    return;
                var platoSeleccionado = (Plato)dgvPlatos.CurrentRow.DataBoundItem;
                if (platoSeleccionado == null)
                    return;
                cbPlatos.SelectedValue = platoSeleccionado.IdPlato;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al seleccionar insumo en la grilla");
            }
        }
    }
}

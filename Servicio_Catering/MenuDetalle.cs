using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity_Catering;

namespace Servicio_Catering
{
    public partial class MenuDetalle : Form
    {
        private Menus _menu;
        private string _modo;
        private readonly HelperFront _helperFront;
        public MenuDetalle(Menus menu, string modo)
        {
            _menu = menu;
            _modo = modo;
            _helperFront = new HelperFront();
            InitializeComponent();
        }


        private void MenuDetalle_Load(object sender, EventArgs e)
        {
            _helperFront.cargarComboSiNo(cbMenuActivo);

            if (_modo == "verDetalle")
            {
                txtNombreMenu.Text = _menu.Nombre;
                txtPrecioMenu.Text = _menu.PrecioPorPersona.ToString();
                preseleccionarActivoYBaja();
                dgvPlatosMenu.DataSource = _menu.Platos;
                dgvPlatosMenu.ReadOnly = true;

                visibilidadBotonesVer();
            }
        }

        private void preseleccionarActivoYBaja()
        {
            if (_menu.FechaDeBaja == null)
            {
                cbMenuActivo.SelectedIndex = cbMenuActivo.FindStringExact("Si");
                lblFechaBajaMenu.Text = "-";
            }
            else
            {
                cbMenuActivo.SelectedIndex = cbMenuActivo.FindStringExact("No");
                lblFechaBajaMenu.Text = _menu.FechaDeBaja.ToString();
            }
        }


        private void visibilidadBotonesVer()
        {
            txtNombreMenu.Enabled = false;
            txtPrecioMenu.Enabled = false;
            cbMenuActivo.Enabled = false;
            dgvPlatosMenu.ReadOnly = true;
            btnAgregarPlato.Visible = false;
            btnEliminarPlato.Visible = false;
        }

        private void cbMenuActivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMenuActivo.Text == "Si")
            {
                lblFechaBajaMenu.Text = "-";
            }
            else if (cbMenuActivo.Text == "No")
            {
                if (_menu.FechaDeBaja == null)
                {
                    lblFechaBajaMenu.Text = DateTime.Now.ToString("dd/MM/yyyy");
                }
                else
                {
                    lblFechaBajaMenu.Text = _menu.FechaDeBaja.ToString();
                }

            }
        }
    }


    
    
}
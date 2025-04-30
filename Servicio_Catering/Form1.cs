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
using Entity_Catering;

namespace Servicio_Catering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            warningMail.Text = "";
            warningPass.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Administracion ventanaChef = new Administracion();
            //ventanaChef.ShowDialog();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            LoginService loginService = new LoginService();
            warningMail.Text = loginService.ValidarUsuario(tbMail.Text);
            warningPass.Text = loginService.ValidarClave(tbPass.Text);
            if (warningMail.Text == "" && warningPass.Text == "")
            {
                Usuario user = loginService.LoginUsuario(tbMail.Text, tbPass.Text);
                if (user == null) { 
                    MessageBox.Show("Mail o clave incorrecta");
                    return;
                }

                if (user.Perfil == Perfil.CHEF.ToString())
                {
                    Administracion ventanaChef = new Administracion(user);
                    ventanaChef.ShowDialog();
                }
                else {
                    MessageBox.Show("Pantallas en construcción");
                }
            }
        }

    }
}

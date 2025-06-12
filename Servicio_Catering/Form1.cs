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
using NLog;

namespace Servicio_Catering
{
    public partial class Form1 : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            warningMail.Text = "";
            warningPass.Text = "";
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            warningMail.Text = usuarioBLL.ValidarUsuario(tbMail.Text);
            warningPass.Text = usuarioBLL.ValidarClave(tbPass.Text);
            if (warningMail.Text == "" && warningPass.Text == "")
            {
                try
                {
                    Usuario user = usuarioBLL.LoginUsuario(tbMail.Text, tbPass.Text);
                    if (user == null)
                    {
                        MessageBox.Show("Mail o clave incorrecta");
                        return;
                    }

                    if (user.Perfil == Perfil.CHEF.ToString())
                    {
                        Administracion ventanaChef = new Administracion(new Chef(user));
                        ventanaChef.ShowDialog();
                    }
                    else if (user.Perfil == Perfil.GERENTE.ToString())
                    {
                        UIGerente ventanaGerente = new UIGerente();
                        ventanaGerente.ShowDialog();

                    }else if (user.Perfil == Perfil.LOGISTICA.ToString())
                    {
                        UILogistica ventanaLogistica = new UILogistica(user);
                        ventanaLogistica.ShowDialog();
                    }
                    else if (user.Perfil == Perfil.VENDEDOR.ToString())
                    {
                        UIVendedor ventanaVendedor = new UIVendedor(user);
                        ventanaVendedor.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Pantallas en construcción");
                    }
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "Error al intentar loguear usuario en UI");
                    MessageBox.Show("Error al intentar loguear usuario");
                    return;
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

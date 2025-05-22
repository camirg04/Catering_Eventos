using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity_Catering;

namespace Servicio_Catering
{
    internal class HelperFront
    {
        public void cargarComboTipoPlato(ComboBox combo)
        {
            combo.Items.Clear();
            List<string> lista = Enum.GetValues(typeof(TipoPlato))
                .Cast<TipoPlato>()
                .Select(e => e.ToString()).ToList();


            foreach (var item in lista) {
                combo.Items.Add(item);
            }
        }

        public void cargarComboEstadoAlerta(ComboBox combo)
        {
            combo.Items.Clear();
            List<string> lista = Enum.GetValues(typeof(EstadoAlertaStock))
                .Cast<EstadoAlertaStock>()
                .Select(e => e.ToString()).ToList();


            foreach (var item in lista)
            {
                combo.Items.Add(item);
            }
        }

        public void cargarComboSiNo(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("Si");
            combo.Items.Add("No");
        }

        public void cargarComboIsumos(ComboBox combo, List<Insumo> insumos)
        {
            combo.DataSource = insumos;
            combo.DisplayMember = "Nombre";  
            combo.ValueMember = "IdInsumo";
            combo.SelectedIndex = -1;
        }

    }
}

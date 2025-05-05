using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Catering
{
    public class PlatoInsumo
    {
        private int _idPlatoInsumo;
        private Insumo _insumo;
        private Decimal _cantidadNecesaria;
        private Plato _plato;

        public PlatoInsumo() { }

        public PlatoInsumo(int idPlatoInsumo, Insumo insumo, int cantidadNecesaria, Plato plato)
        {
            _idPlatoInsumo = idPlatoInsumo;
            _insumo = insumo;
            _cantidadNecesaria = cantidadNecesaria;
            _plato = plato;
        }

        public int IdPlatoInsumo
        {
            get { return _idPlatoInsumo; }
            set { _idPlatoInsumo = value; }
        }
        public Insumo Insumo
        {
            get { return _insumo; }
            set { _insumo = value; }
        }
        public Decimal CantidadNecesaria
        {
            get { return _cantidadNecesaria; }
            set { _cantidadNecesaria = value; }
        }
        public Plato Plato
        {
            get { return _plato; }
            set { _plato = value; }
        }
    }
}

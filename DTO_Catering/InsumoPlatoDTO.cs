using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Catering;

namespace DTO_Catering
{
    public class InsumoPlatoDTO
    {
        private int _idInsumoPlato;
        private int _idInsumo;
        private string _nombreInsumo;
        private Decimal _cantidadNecesaria;
        private string _unidadMedida;
 
        public InsumoPlatoDTO() { }

        public InsumoPlatoDTO(int idInsumoPlato, int idInsumo, Decimal cantidadNecesaria, string nombreInsumo, string unidadMedida)
        {
            _idInsumoPlato = idInsumoPlato;
            _idInsumo = idInsumo;
            _cantidadNecesaria = cantidadNecesaria;
            _nombreInsumo = nombreInsumo;
            _unidadMedida = unidadMedida;
        }

       
        public int IdInsumoPlato
        {
            get { return _idInsumoPlato; }
            set { _idInsumoPlato = value; }
        }
        public int IdInsumo
        {
            get { return _idInsumo; }
            set { _idInsumo = value; }
        }
        [DisplayName("Nombre")]
        public string NombreInsumo
        {
            get { return _nombreInsumo; }
            set { _nombreInsumo = value; }
        }

        [DisplayName("Cantidad necesaria")]
        public Decimal CantidadNecesaria
        {
            get { return _cantidadNecesaria; }
            set { _cantidadNecesaria = value; }
        }

        [DisplayName("Unidad de medida")]
        public string UnidadMedida
        {
            get { return _unidadMedida; }
            set { _unidadMedida = value; }
        }


        // Método para mapear un objeto PlatoInsumo a InsumoPlatoDTO
        public static InsumoPlatoDTO mapPlatoInsumoToInsumoPlatoDTO(PlatoInsumo platoInsumo)
        {
            var insumoPlatoDTO = new InsumoPlatoDTO();

            insumoPlatoDTO.IdInsumoPlato = platoInsumo.IdPlatoInsumo;
            insumoPlatoDTO.CantidadNecesaria = platoInsumo.CantidadNecesaria;

            if (platoInsumo.Insumo != null)
            {
                insumoPlatoDTO.IdInsumo = platoInsumo.Insumo.IdInsumo;
                insumoPlatoDTO.NombreInsumo = platoInsumo.Insumo.Nombre;
                insumoPlatoDTO.UnidadMedida = platoInsumo.Insumo.UnidadMedida;
            }

            return insumoPlatoDTO;
        }

        public static List<InsumoPlatoDTO> mapPlatoInsumoListToInsumoPlatoDTOList(List<PlatoInsumo> listaPlatoInsumo)
        {
            List<InsumoPlatoDTO> listaInsumoPlatoDTO = new List<InsumoPlatoDTO>();
            foreach (var platoInsumo in listaPlatoInsumo)
            {
                listaInsumoPlatoDTO.Add(mapPlatoInsumoToInsumoPlatoDTO(platoInsumo));
            }
            return listaInsumoPlatoDTO;
        }

        public static BindingList<InsumoPlatoDTO> mapPlatoInsumoListToInsumoPlatoDTOBindingList(List<PlatoInsumo> listaPlatoInsumo)
        {
            BindingList<InsumoPlatoDTO> listaInsumoPlatoDTO = new BindingList<InsumoPlatoDTO>();
            foreach (var platoInsumo in listaPlatoInsumo)
            {
                listaInsumoPlatoDTO.Add(mapPlatoInsumoToInsumoPlatoDTO(platoInsumo));
            }
            return listaInsumoPlatoDTO;
        }
    }
}

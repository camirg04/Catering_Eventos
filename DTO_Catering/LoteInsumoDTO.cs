using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Catering;

namespace DTO_Catering
{
    public class LoteInsumoDTO
    {
        private int _idLoteInsumo;
        private int _idInsumo;
        private string _nombreInsumo;
        private string _unidadMedida;
        private int _idPedidoInsumo;
        private Decimal _cantidad;
        private Decimal _costoUnitario;
        private DateTime _fechaIngreso;
        private DateTime? _fechaVencimiento;
        private string _severidad;

        public LoteInsumoDTO() { }

        public LoteInsumoDTO(int idLoteInsumo, int idInsumo, string nombreInsumo, string unidadMedida, int idPedidoInsumo, Decimal cantidad, Decimal costoUnitario, DateTime fechaIngreso, DateTime? fechaVencimiento)
        {
            IdLoteInsumo = idLoteInsumo;
            IdInsumo = idInsumo;
            NombreInsumo = nombreInsumo;
            UnidadMedida = unidadMedida;
            IdPedidoInsumo = idPedidoInsumo;
            Cantidad = cantidad;
            CostoUnitario = costoUnitario;
            FechaIngreso = fechaIngreso;
            FechaVencimiento = fechaVencimiento;
            Severidad = "Nula";
        }

        public int IdLoteInsumo { get => _idLoteInsumo; set => _idLoteInsumo = value; }
        public int IdInsumo { get => _idInsumo; set => _idInsumo = value; }

        public string Severidad { get => _severidad; set => _severidad = value; }

        [DisplayName("Insumo")]
        public string NombreInsumo { get => _nombreInsumo; set => _nombreInsumo = value; }

        [DisplayName("Unidad medida")]
        public string UnidadMedida { get => _unidadMedida; set => _unidadMedida = value; }
        public int IdPedidoInsumo { get => _idPedidoInsumo; set => _idPedidoInsumo = value; }

        public decimal Cantidad { get => _cantidad; set => _cantidad = value; }
        [DisplayName("Costo unitario")]
        public decimal CostoUnitario { get => _costoUnitario; set => _costoUnitario = value; }

        [DisplayName("Ingreso")]
        public DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }
        [DisplayName("Vencimiento")]
        public DateTime? FechaVencimiento { get => _fechaVencimiento; set => _fechaVencimiento = value; }


        public static LoteInsumoDTO mapLoteInsumoToLoteInsumoDTO(LoteInsumo lote) {
            var loteInsumoDTO = new LoteInsumoDTO();
            loteInsumoDTO.IdLoteInsumo = lote.IDLoteInsumo;
            loteInsumoDTO.IdInsumo = lote.Insumo.IdInsumo;
            loteInsumoDTO.NombreInsumo = lote.Insumo.Nombre;
            loteInsumoDTO.UnidadMedida = lote.Insumo.UnidadMedida;
            loteInsumoDTO.IdPedidoInsumo = lote.PedidoInsumo.IdPedidoInsumo;
            loteInsumoDTO.Cantidad = lote.Cantidad;
            loteInsumoDTO.CostoUnitario = lote.CostoUnitario;
            loteInsumoDTO.FechaIngreso = lote.FechaIngreso;
            loteInsumoDTO.FechaVencimiento = lote.FechaVencimiento;
            return loteInsumoDTO;
        }

        public static List<LoteInsumoDTO> mapLoteInsumoListToLoteInsumoDTOList(List<LoteInsumo> lotes)
        {
            List<LoteInsumoDTO> loteInsumoDTOs = new List<LoteInsumoDTO>();
            foreach (var lote in lotes)
            {
                loteInsumoDTOs.Add(mapLoteInsumoToLoteInsumoDTO(lote));
            }
            return loteInsumoDTOs;
        }
    }
}

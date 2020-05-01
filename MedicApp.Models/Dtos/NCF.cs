using System;
using Dapper.Contrib.Extensions;
namespace MedicApp.Models.Dtos
{
    public class NCF
    {
        [Key]
        public int NCFId { get; set; }


        public string CodigoNCF { get; set; }

        public string Nombre { get; set; }

        public string Prefijo { get; set; }


        public decimal? Secuencia { get; set; }


        public decimal? UltimoNCF { get; set; }


        public string Aviso { get; set; }


        public decimal? Modulo { get; set; }

        public string TipoNCF { get; set; }

        public bool? RNC { get; set; }

        public decimal? Valor { get; set; }

        public DateTime? Fvencimiento { get; set; }

        public bool? Status { get; set; }
    }
}

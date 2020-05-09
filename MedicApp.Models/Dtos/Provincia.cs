using Dapper.Contrib.Extensions;
namespace MedicApp.Models.Dtos
{
    public class Provincia
    {
        [Key]
        public int ProvinciaId { get; set; }


        public string Nombre { get; set; }
        public bool Status { get; set; }

    }
}

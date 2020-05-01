using Dapper.Contrib.Extensions;
namespace MedicApp.Models.Dtos
{
    public class Sector
    {
        
        [Key]
        public int SectorId { get; set; }


        public string Nombre { get; set; }


        public string CodigoPostal { get; set; }
    }
}

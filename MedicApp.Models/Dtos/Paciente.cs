using System;

namespace MedicApp.Models.Dtos
{
    public class Paciente
    {
        public int IdPaciente { get; set; }

       
        public string Nombre { get; set; }

      
        public string Apellido { get; set; }

        public DateTime? Fnacimiento { get; set; }

        public bool Status { get; set; }

     
        public DateTime Fmodificacion { get; set; }

     
        public DateTime Fcreacion { get; set; }

      
        public string Cedula { get; set; }

        
        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public int ProvinciaId { get; set; }

        public int SectorId { get; set; }

        public int ARSId { get; set; }

      
        public string TipoSangre { get; set; }

        public string Genero { get; set; }

       
        public string Email { get; set; }

        public string Imagen { get; set; }

       
        public string Alergico { get; set; }

    
        public string Ocupacion { get; set; }

       
        public string EstadoCivil { get; set; }

        
        public string Peso { get; set; }

      
        public string Estatura { get; set; }

        public bool? Fuma { get; set; }

        public bool? Bebe { get; set; }

   
        public string Lat { get; set; }

       
        public string Log { get; set; }

    
        public string NoAfiliadoARS { get; set; }

    
        public string NombreContacto { get; set; }

   
        public string TelefonoContacto { get; set; }

    }
}

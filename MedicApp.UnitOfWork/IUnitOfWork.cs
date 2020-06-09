using MedicApp.Repositories;

namespace MedicApp.UnitOfWork
{

//Esta es una interface que contiene las interfaces de los respositorios que utilizo para modificar mi estructura
//Esto se usa por un patron llamado UNItOfwork 

/*En primera instancia UoW soluciona un problema sobre las conexiones a la base de datos y
permite encapsular dichas consultas a la
DB en una sola pudiendo así hacer varias tareas y al final realizar los cambios.*/

//Mas referencias https://anexsoft.com/ejemplo-de-unit-of-work-con-c

    public interface IUnitOfWork
    {
        
        IMedicoRepository Medico { get; }
        ISectorRepository Sector { get; }
        IConsultoriosRepository Consultorio { get; }
        IArsRepository ARS { get; }
        IPacienteRepository Paciente { get; }
        IProvinciaRepository Provincia { get; }
        IServicioRepository Servicio { get; }
        INCFRepository NCF { get; }
        IDocumentosRepository Documentos { get; }
        ICitasRepository Citas { get; }
        IUsuarioRepository Usuario { get; }
    }
}

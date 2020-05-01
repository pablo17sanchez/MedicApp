using MedicApp.Repositories;

namespace MedicApp.UnitOfWork
{
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
    }
}

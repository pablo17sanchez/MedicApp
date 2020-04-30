using MedicApp.Repositories;
using MedicApp.UnitOfWork;

namespace MedicApp.DataAccess
{
    public class MedicAppUnitOfWork : IUnitOfWork
    {
        public MedicAppUnitOfWork(string connectionString)
        {
            ARS = new ARSRepository(connectionString);
            Medico = new MedicoRepository(connectionString);
            Sector = new SectorRepository(connectionString);
            Consultorio = new ConsultorioRepository(connectionString);
            Paciente = new PacienteRepository(connectionString);
            Provincia = new ProvinciaRepository(connectionString);
            Servicio = new ServicioRepository(connectionString);
        }

        public IMedicoRepository Medico { get; private set; }

        public ISectorRepository Sector { get; private set; }

        public IConsultoriosRepository Consultorio { get; private set; }

        public IArsRepository ARS { get; private set; }

        public IPacienteRepository Paciente { get; private set; }

        public IProvinciaRepository Provincia { get; private set; }

        public IServicioRepository Servicio { get; private set; }
}
}

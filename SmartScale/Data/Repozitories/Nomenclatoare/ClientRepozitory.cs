using SmartScale.Data.Repozitories.Nomenclatoare;
using SmartScales.Model;
using SmartScale.DataAccess;

namespace SmartSCALE.Data.Repozitories.Nomenclatoare
{
    public class ClientRepozitory : GenericRepository<Clienti, ScaleDBContext>, IClientRepository
    {        
        public ClientRepozitory(ScaleDBContext context) : base(context)
        {
        }
    }
}

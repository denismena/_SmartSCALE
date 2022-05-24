using SmartScale.Data.Repozitories.Nomenclatoare;
using SmartScales.Model;
using SmartScale.DataAccess;

namespace SmartSCALE.Data.Repozitories
{
    public class CantarireRepozitory : GenericRepository<Clienti, ScaleDBContext>, ICantarireRepozitory
    {
        public CantarireRepozitory(ScaleDBContext context) : base(context)
        {
        }
    }
}

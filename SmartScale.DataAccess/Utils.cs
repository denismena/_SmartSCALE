using System.Linq;
using SmartScales.Model;

namespace SmartScale.DataAccess
{
    public class Utils
    {
        public static void StartDatabaseMigrations()
        {
            ScaleDBContext db = new ScaleDBContext();
            db.Articole.Count();
            db.Clienti.Count();
            db.Furnizori.Count();
            db.Masini.Count();
            db.Operatori.Count();
            db.Settings.Count();
            db.Soferi.Count();
            db.Operatori.Count();
            db.SetariCantare.Count();
        }
    }
}

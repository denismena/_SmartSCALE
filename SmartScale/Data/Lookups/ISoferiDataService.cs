using System.Collections.Generic;
using System.Threading.Tasks;
using SmartScales.Model;

namespace SmartScale.Data.Lookups
{
    public interface ISoferiDataService
    {
        Task<IEnumerable<LookupItem>> GetSoferiLookupAsync();
    }
}

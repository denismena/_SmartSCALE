using System.Collections.Generic;
using System.Threading.Tasks;
using SmartScales.Model;

namespace SmartScale.Data.Lookups
{
    public interface IOperatoriDataService
    {
        Task<IEnumerable<LookupItem>> GetOperatoriLookupAsync();
    }
}

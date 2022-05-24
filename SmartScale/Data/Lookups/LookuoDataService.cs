using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SmartScale.DataAccess;
using SmartScales.Model;
using System.Linq;
using System.Data.Entity;

namespace SmartScale.Data.Lookups
{
    public class LookuoDataService : IArticoleDataService, IClientiDataService, IFurnizoriDataService, IMasiniDataService,
                        IOperatoriDataService, ISoferiDataService
    {
        private Func<ScaleDBContext> _contextCreator;
        public LookuoDataService(Func<ScaleDBContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<IEnumerable<LookupItem>> GetArticoleLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Articole.AsNoTracking()
                    .Select(s => new LookupItem
                    {
                        Id = s.ArticolId,
                        DisplayMember = s.DenumireArticol
                    })
                    .ToListAsync();
            }
        }

        public async Task<IEnumerable<LookupItem>> GetClientiLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Clienti.AsNoTracking()
                    .Select(s => new LookupItem
                    {
                        Id = s.ClientId,
                        DisplayMember = s.DenumireClient
                    })
                    .ToListAsync();
            }
        }        

        public async Task<IEnumerable<LookupItem>> GetFurnizoriLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Furnizori.AsNoTracking()
                    .Select(s => new LookupItem
                    {
                        Id = s.FurnizorId,
                        DisplayMember = s.DenumireFurnizor
                    })
                    .ToListAsync();
            }
        }

        public async Task<IEnumerable<LookupItem>> GetMasiniLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Masini.AsNoTracking()
                    .Select(s => new LookupItem
                    {
                        Id = s.MasiniId,
                        DisplayMember = s.NrAuto
                    })
                    .ToListAsync();
            }
        }

        public async Task<IEnumerable<LookupItem>> GetOperatoriLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Operatori.AsNoTracking()
                    .Select(s => new LookupItem
                    {
                        Id = s.OperatorId,
                        DisplayMember = s.NumePrenumeOperator
                    })
                    .ToListAsync();
            }
        }

        public async Task<IEnumerable<LookupItem>> GetSoferiLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Soferi.AsNoTracking()
                    .Select(s => new LookupItem
                    {
                        Id = s.SoferId,
                        DisplayMember = s.NumeSofer + " " + s.PrenumeSofer
                    })
                    .ToListAsync();
            }
        }
    }
}

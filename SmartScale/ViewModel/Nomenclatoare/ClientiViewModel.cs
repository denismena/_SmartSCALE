using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using SmartSCALE.Data.Repozitories.Nomenclatoare;
using SmartScales.Model;

namespace SmartSCALE.ViewModel.Nomenclatoare
{
    public class ClientiViewModel : DetailViewModelBase, IClientiViewModel
    {
        private IClientRepository _clientRepozitory;
        public ClientiViewModel(IClientRepository clientRepozitory, IEventAggregator eventAggregator) : base(eventAggregator)
        {
            _clientRepozitory = clientRepozitory;
        }

        public async override Task LoadAsync(int? id)
        {
            var client = id.HasValue ? await _clientRepozitory.GetByIdAsync(id.Value) : CreateNewClient();
        }

        //public ClientWrapper Friend
        //{
        //    get { return _friend; }
        //    private set
        //    {
        //        _friend = value;
        //        OnPropertyChanged();
        //    }
        //}
        protected async override void OnDeleteExecute()
        {
            //_clientRepozitory.Remove(Friend.Model);
            await _clientRepozitory.SaveAsync();
            //RaiseDetailDeletedEvent(Friend.Id);
        }

        protected override bool OnSaveCanExecute()
        {
            throw new NotImplementedException();
        }

        protected override void OnSaveExecute()
        {
            throw new NotImplementedException();
        }

        private Clienti CreateNewClient()
        {
            var client = new Clienti();
            _clientRepozitory.Add(client);
            return client;
        }
    }
}

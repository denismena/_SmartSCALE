using System.Threading.Tasks;
using Autofac.Features.Indexed;

namespace SmartSCALE.ViewModel.Nomenclatoare
{
    public class MainViewModel : ViewModelBase
    {
        private IDetailViewModel _detailViewModel;
        private IIndex<string, IDetailViewModel> _detailViewModelCreator;

        public MainViewModel(
                IIndex<string, IDetailViewModel> detailViewModelCreator)
        {            
            _detailViewModelCreator = detailViewModelCreator;

            //NavigationViewModel = navigationViewModel;
        }
        public async Task LoadAsync()
        {
            await NavigationViewModel.LoadAsync();
        }
        public INavigationViewModel NavigationViewModel { get; }

        public IDetailViewModel DetailViewModel
        {
            get { return _detailViewModel; }
            private set
            {
                _detailViewModel = value;
                OnPropertyChanged();
            }
        }
    }    
}

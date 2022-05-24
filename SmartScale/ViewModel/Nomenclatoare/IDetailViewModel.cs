using System.Threading.Tasks;

namespace SmartSCALE.ViewModel.Nomenclatoare
{
    public interface IDetailViewModel
    {
        Task LoadAsync(int? id);
        bool HasChanges { get; }
    }
}
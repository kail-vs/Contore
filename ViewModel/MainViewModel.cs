using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Contore.Views;

namespace Contore.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [RelayCommand]
        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync(nameof(UtilityPage));
        }
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Contore.Views;

namespace Contore.ViewModel
{
    public partial class UtilityViewModel : ObservableObject
    {
        [RelayCommand]
        async Task ToSelectionPage(string s)
        {
            await Shell.Current.GoToAsync(nameof(SelectionPage));
        }

        [RelayCommand]
        async Task ToSummarizationPage(string s)
        {
            await Shell.Current.GoToAsync(nameof(SummarizationPage));
        }
    }
}

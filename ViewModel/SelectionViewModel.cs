using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Contore.Model;

namespace Contore.ViewModel
{
    public partial class SelectionViewModel : ObservableObject
    {
        public ObservableCollection<Language> Languages { get; }

        public SelectionViewModel(LanguageService languageService)
        {
            Languages = new ObservableCollection<Language>(languageService.Languages);
        }
    }
}

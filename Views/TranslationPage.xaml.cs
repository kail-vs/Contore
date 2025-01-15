using Contore.ViewModel;

namespace Contore.Views;

public partial class TranslationPage : ContentPage
{
	public TranslationPage(TranslationViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
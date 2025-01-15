using Contore.ViewModel;

namespace Contore.Views;

public partial class SummarizationPage : ContentPage
{
	public SummarizationPage(SummarizationViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
using Contore.ViewModel;

namespace Contore.Views;

public partial class UtilityPage : ContentPage
{
	public UtilityPage(UtilityViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;

	}
}
using Contore.Model;
using Contore.ViewModel;
namespace Contore.Views;

public partial class SelectionPage : ContentPage
{
	public SelectionPage(SelectionViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
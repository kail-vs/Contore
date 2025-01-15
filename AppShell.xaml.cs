using Contore.Views;

namespace Contore
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(UtilityPage), typeof(UtilityPage));
            Routing.RegisterRoute(nameof(SelectionPage), typeof(SelectionPage));
            Routing.RegisterRoute(nameof(SummarizationPage), typeof(SummarizationPage));
            Routing.RegisterRoute(nameof(TranslationPage), typeof(TranslationPage));
        }
    }
}

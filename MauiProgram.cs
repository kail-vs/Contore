using Contore.ViewModel;
using Contore.Views;
using Microsoft.Extensions.Logging;

namespace Contore
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

            builder.Services.AddTransient<UtilityPage>();
            builder.Services.AddTransient<UtilityViewModel>();

            builder.Services.AddTransient<SelectionPage>();
            builder.Services.AddTransient<SelectionViewModel>();

            builder.Services.AddTransient<SummarizationPage>();
            builder.Services.AddTransient<SummarizationViewModel>();

            builder.Services.AddTransient<TranslationPage>();
            builder.Services.AddTransient<TranslationViewModel>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

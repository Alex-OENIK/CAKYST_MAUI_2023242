using Microsoft.Extensions.Logging;
using SemesterProject.GUI.ViewModels;

namespace SemesterProject.GUI
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<Backend>();
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<CreatePageViewModel>();
            builder.Services.AddSingleton<CreatePage>();
            builder.Services.AddSingleton<UpdatePageViewModel>();
            builder.Services.AddSingleton<UpdatePage>();
            builder.Services.AddSingleton<QueryPageViewModel>();
            builder.Services.AddSingleton<QueryPage>();
            return builder.Build();
        }
    }
}

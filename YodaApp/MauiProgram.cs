﻿using Microsoft.Extensions.Logging;
using YodaApp.Configuration;
using YodaApp.Services;
using YodaApp.Services.Interface;
using YodaApp.ViewModels;
using YodaApp.Views;


namespace YodaApp
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

            // Register services, view models, and views
            builder.RegisterViewModels()
                   .RegisterViews()
                   .RegisterServices();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
        {

            mauiAppBuilder.Services.AddTransient<ISetting, ConstantSetting>();
            mauiAppBuilder.Services.AddTransient<IAiAssistant, YodaAiAssistant>();
            return mauiAppBuilder;
        
        }
        
        
        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<YodaAnswerViewModel>();
            //mauiAppBuilder.Services.AddSingleton<LoadsheddingAnswerViewModel>();

            // More view-models registered here.

            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<YodaAnswerPage>();
            //mauiAppBuilder.Services.AddSingleton<LoadsheddingAnswerPage>();

            // More views registered here.

            return mauiAppBuilder;
        }
    }
}

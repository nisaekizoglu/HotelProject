﻿using HotelProjectMauiApp.Pages;
using Microsoft.Extensions.Logging;

namespace HotelProjectMauiApp
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
            builder.Services.AddTransient<CategoriesPage>();
            builder.Services.AddTransient<CreateCategoryPage>();
            builder.Services.AddTransient<UpdateCategoryPage>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

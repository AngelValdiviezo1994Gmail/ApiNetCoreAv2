﻿using Microsoft.AspNetCore.Mvc;
using AngelValdiviezoWebApi.Middleware;

namespace AngelValdiviezoWebApi.Extensions;

public static class ServiceExtensions
{
    public static void AddServiceExtensions(this IServiceCollection services)
    {
        services.AddApiVersioning(config =>
        {
            config.DefaultApiVersion = new ApiVersion(1, 0);
            config.AssumeDefaultVersionWhenUnspecified = true;
            config.ReportApiVersions = true;

        });
        services.AddSingleton<ErrorHandlerMiddleware>();
    }
}

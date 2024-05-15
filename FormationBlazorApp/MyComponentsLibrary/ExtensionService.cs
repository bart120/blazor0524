using Microsoft.Extensions.DependencyInjection;
using MyComponentsLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComponentsLibrary
{
    public static class MyComponentsLibraryExtension
    {

        public static IServiceCollection AddMyComponentsServices(this IServiceCollection services)
        {
            services.AddScoped<ToastService>();
            return services;
        }
    }
}

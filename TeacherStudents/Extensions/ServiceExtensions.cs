using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudents.Extensions
{
    public static class ServiceExtensions
    {
        //CORS
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", policy =>
                {
                    policy.AllowAnyHeader()
                          .AllowAnyMethod()
                          .AllowAnyOrigin();
                });
            });

        //IIS Integration
        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            });
    }
}

using Mevzuat6n._3Service.Services.Abstractions;
using Mevzuat6n._3Service.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mevzuat6n._3Service.Services.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddScoped<IArticleService, ArticleService>();
            //services.AddScoped<ICategoryService, CategoryService>();
            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<IImageHelper, ImageHelper>();
            //services.AddScoped<IDashbordService, DashboardService>();

            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //services.AddAutoMapper(assembly);


            //services.AddControllersWithViews()
            //    .AddFluentValidation(opt =>
            //    {
            //        opt.RegisterValidatorsFromAssemblyContaining<ArticleValidator>();
            //        opt.DisableDataAnnotationsValidation = true;
            //        opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
            //    });

            return services;
        }
    }
}

using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Handlers;
using OrchardCore.ContentTypes.Editors;
using OrchardCore.Data.Migration;
using ModuleName.OrchardCore.Drivers;
using ModuleName.OrchardCore.Handlers;
using ModuleName.OrchardCore.Models;
using ModuleName.OrchardCore.Settings;
using OrchardCore.Modules;

namespace ModuleName.OrchardCore
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IContentPartDisplayDriver, TestPartPartDisplayDriver>();
            services.AddSingleton<ContentPart, TestPartPart>();
            services.AddScoped<IContentPartDefinitionDisplayDriver, TestPartPartSettingsDisplayDriver>();
            services.AddScoped<IDataMigration, Migrations>();
            services.AddScoped<IContentPartHandler, TestPartPartHandler>();
        }

        public override void Configure(IApplicationBuilder builder, IRouteBuilder routes, IServiceProvider serviceProvider)
        {
            routes.MapAreaRoute(
                name: "Home",
                areaName: "ModuleName.OrchardCore",
                template: "Home/Index",
                defaults: new { controller = "Home", action = "Index" }
            );
        }
    }
}
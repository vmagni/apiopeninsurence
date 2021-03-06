using Caixa.OpenInsurence.Api.Configs;
using Caixa.OpenInsurence.Data.Interfaces;
using Caixa.OpenInsurence.Data.Services;
using Caixa.OpenInsurence.Service.Interfaces;
using Caixa.OpenInsurence.Service.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Channels.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Caixa.OpenInsurence.Channels.Api", Version = "v1" });
                //c.OperationFilter<HeaderFilter>();
            });

            //INTERFACES
            services.AddScoped<IChannelsService, ChannelsService>();
            services.AddScoped<IPensionPlansService, PensionPlansService>();
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<ILifePensionService, LifePensionService>();
            services.AddScoped<IDatabaseService, DatabaseService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<ITokenConfigManager, TokenConfigManager>();

            //SERVICES
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .WithHeaders("Cache-Control", "Content-Security-Policy", "Content-Type", "Strict-Transport-Security", "X-Content-Type-Options", "X-Frame-Options");
            }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Caixa.OpenInsurence.Channels.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

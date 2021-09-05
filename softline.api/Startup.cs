using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using softline.core;
using softline.db.Context;
using softline.core.Interfaces;
using softline.core.Services;

namespace softline.api {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddControllers();

            services.AddDbContext<ObjectivesContext>();

            services.AddTransient<IObjectivesServices, ObjectivesServices>();

            services.AddTransient<IStatusesServices, StatusesServices>();

            services.AddSwaggerDocument(settings => {
                settings.Title = "Objectives";
            });

            services.AddCors(options => {
                options.AddPolicy("ObjectivesPolicy",
                    builder => {
                        builder.WithOrigins("*")
                               .AllowAnyHeader()
                               .AllowAnyMethod();
                    });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("ObjectivesPolicy");

            app.UseAuthorization();

            app.UseOpenApi();

            app.UseSwaggerUi3();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}

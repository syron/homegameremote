﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homegameauto.repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace homegameauto.api
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
            services.AddMvc();

            string gameConsolesFolder = Configuration["GameSettings:GameConsolesFolder"];
            string gamesFolder = Configuration["GameSettings:GamesFolder"];

            services.AddScoped<IGameConsoleRepository>(gcr => new GameConsoleRepository(gameConsolesFolder));
            services.AddScoped<IGameRepository>(gr => new GameRepository(gamesFolder));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(options => {
                options.AllowAnyHeader();
                options.AllowAnyMethod();
                options.AllowAnyOrigin();
            });

            app.UseMvc();
        }
    }
}

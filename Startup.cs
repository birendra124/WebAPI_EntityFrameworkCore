using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeWheelMovieAPI.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using FreeWheelMovieAPI.Models.Repository;
using FreeWheelMovieAPI.Models.DataManagers;
using AutoMapper;
using FreeWheelMovieAPI.AutoMapper;
using System.IO;
using FreeWheelMovieAPI.Shared;
using NLog;
using FreeWheelMovieAPI.Shared.CustomExceptionMiddleware;
using Swashbuckle.AspNetCore.Swagger;

namespace FreeWheelMovieAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            //LogManager.LoadConfiguration(String.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<MovieDBContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:FreeWheelMovieDB"]));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddScoped<IDataRepository<Movie>, MovieManager>();
            services.AddScoped<IDataRepository<User>, UserManager>();
            services.AddScoped<IDataRepository<Genre>, GenreManager>();
            services.AddScoped<IGenreDataRepository, GenreManager>();
            services.AddScoped<IMovieApiRepository, MovieApiManager>();
            services.AddSingleton<ILoggerManager, LoggerManager>();
            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "FreeWheelMovieAPI",
                    Description = "Movie API Testing"
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "MoviesStore");
            });
            app.UseMiddleware<ExceptionMiddleware>();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}

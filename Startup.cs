using System;
using BasisMap.Interfaces;
using BasisMap.Models;
using BasisMap.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BasisMap.DBContext;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using BasisMap.Models.Repositories;

namespace BasisMap
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();


        }
        // This method gets called by the runtime. Use this method to add services to the container.
        public IConfigurationRoot Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseInMemoryDatabase()
            //);
          //  var connStr = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExternalLTGWarehouse;Integrated Security=True;Trusted_Connection=True;");
           var connStr = (@"Data Source=DVAZRCAPDB01.LANSING.LOCAL\DEVCAPS;Initial Catalog=LTGWarehouse;Integrated Security=SSPI;Trusted_Connection=True;");
            services.AddDbContext<ltgwarehouseContext>(options =>
                 options.UseSqlServer(connStr));

            // Add framework services.
            services.AddMvc();
            services.AddApplicationInsightsTelemetry(Configuration);

            // Register application services.
            services.AddScoped<ICommodityRepository, CommodityRepository>();
            //services.AddTransient<IOperationTransient, Operation>();
            //services.AddScoped<IOperationScoped, Operation>();
            //services.AddSingleton<IOperationSingleton, Operation>();
            //services.AddSingleton<IOperationSingletonInstance>(new Operation(Guid.Empty));
            //services.AddTransient<OperationService, OperationService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

        //    original from working demo.
        //public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        //{
        //    if (env.IsDevelopment())
        //    {
        //        app.UseDeveloperExceptionPage();
        //    }

        //    app.UseStaticFiles();

        //    app.UseMvcWithDefaultRoute();
        //}
        //This method is invoked when ASPNETCORE_ENVIRONMENT is 'Development' or is not defined
        //The allowed values are Development,Staging and Production
        public void ConfigureDevelopment(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(minLevel: LogLevel.Information);

            // StatusCode pages to gracefully handle status codes 400-599.
            app.UseStatusCodePagesWithRedirects("~/Home/StatusCodePage");

            // Display custom error page in production when error occurs
            // During development use the ErrorPage middleware to display error information in the browser
            app.UseDeveloperExceptionPage();

            app.UseDatabaseErrorPage();

            Configure(app);
        }

        //This method is invoked when ASPNETCORE_ENVIRONMENT is 'Staging'
        //The allowed values are Development,Staging and Production
        public void ConfigureStaging(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(minLevel: LogLevel.Warning);

            // StatusCode pages to gracefully handle status codes 400-599.
            app.UseStatusCodePagesWithRedirects("~/Home/StatusCodePage");

            app.UseExceptionHandler("/Home/Error");

            Configure(app);
        }

        //This method is invoked when ASPNETCORE_ENVIRONMENT is 'Production'
        //The allowed values are Development,Staging and Production
        public void ConfigureProduction(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(minLevel: LogLevel.Warning);

            // StatusCode pages to gracefully handle status codes 400-599.
            app.UseStatusCodePagesWithRedirects("~/Home/StatusCodePage");

            app.UseExceptionHandler("/Home/Error");

            Configure(app);
        }
        public void Configure(IApplicationBuilder app/*, IHostingEnvironment env, ILoggerFactory loggerFactory*/)
        {
            //loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            //loggerFactory.AddDebug();

            app.UseApplicationInsightsRequestTelemetry();

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //    app.UseBrowserLink();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //}

            app.UseApplicationInsightsExceptionTelemetry();
            // Configure Session.
            app.UseSession();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            ServiceProviderConfig.InitializeMusicStoreDatabaseAsync(app.ApplicationServices).Wait();
        }
    }
}

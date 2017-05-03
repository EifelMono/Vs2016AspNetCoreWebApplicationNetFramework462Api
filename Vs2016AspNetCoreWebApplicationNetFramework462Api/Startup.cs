using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Swashbuckle.Swagger.Model;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace Vs2016AspNetCoreWebApplicationNetFramework462Api
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

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SingleApiVersion(new Info
                {
                    Version = "v1",
                    Title = "Test Title",
                    Description = "Test Description",
                    TermsOfService = "None",
                    Contact = new Contact
                    {
                        Name = "Andreas Klapperich",
                        Email = "andreas@klapperich.de",
                        Url = "http://klapperich.de"
                    },
                    License = new License
                    {
                        Name = "Use under LICX",
                        Url = "http://klapperich.de"
                    }
                });
                //{
                //    var xmlPath = Path.ChangeExtension(Environment.GetCommandLineArgs()[0], ".xml");
                //    options.IncludeXmlComments(xmlPath);
                //}
                {
                    // Include all Xml's
                    var xmlPathBase = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
                    foreach (var filename in Directory.GetFiles(xmlPathBase, "*.xml"))
                    {
                        try
                        {
                            // Test if it contains an controller!!!!
                            options.IncludeXmlComments(filename);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }

                    }

                }

            });
            // Add framework services.
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseSwagger();

            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();

            app.UseSwaggerUi();

            DefaultFilesOptions DefaultFile = new DefaultFilesOptions();
            DefaultFile.DefaultFileNames.Clear();
            DefaultFile.DefaultFileNames.Add("swagger/ui/index.html");
            app.UseDefaultFiles(DefaultFile);
            app.UseStaticFiles();
        }
    }
}

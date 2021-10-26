using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlyStyle.Rules;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace OnlyStyle
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
            // добавляем сервис компрессии
            // Configure Compression level
            services.Configure<GzipCompressionProviderOptions>(options => options.Level = CompressionLevel.Fastest);
            services.AddResponseCompression(options =>
            {
                IEnumerable<string> MimeTypes = new[]
                {
                    // General
                    "text/plain",
                    "text/html",
                    "text/css",
                    "font/woff2",
                    "application/javascript",
                    "image/x-icon",
                    "image/png"
                };
                options.Providers.Add<BrotliCompressionProvider>();
                options.Providers.Add<GzipCompressionProvider>();
                options.EnableForHttps = true;
                options.MimeTypes = MimeTypes;

            });
            //Нижний регистр для url-адресов
            services.AddRouting(options => options.LowercaseUrls = true);

            services.AddControllersWithViews();

            services.AddResponseCaching();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            var optionsRewrite = new RewriteOptions()
               .AddRedirect("(.*)/$", "$1"); //Удаление косой черты в конце
            optionsRewrite.Add(new RedirectLowerCaseRule()); //Перенаправление на нижний регистр
            app.UseRewriter(optionsRewrite);

            // обработка ошибок HTTP
            app.UseStatusCodePagesWithReExecute("/Home/ErrorStatus/{0}");

            app.UseHttpsRedirection();

            // подключаем компрессию
            app.UseResponseCompression();

            //Кэширование статичных файлов
            app.UseStaticFiles(new StaticFileOptions()
            {
                OnPrepareResponse = (ctx) =>
                {
                    ctx.Context.Response.Headers.Add("Cache-Control", "public,max-age=31536000");
                }
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseResponseCaching();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

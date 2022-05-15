using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webRGE.Context;
using webRGE.Services;

namespace webRGE
{
    public record Startup(IConfiguration Configuration)
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddDbContext<RgeDb>(opt => opt.UseSqlServer(Configuration.GetConnectionString("Default")));
            services.AddScoped<RgeDb>();            
            services.AddTransient<ParcerService>();
            services.AddSingleton<CommonService>();

            services.AddMvc();
            services.Configure<FormOptions>(o =>  // currently all set to max, configure it to your needs!
            {
                o.ValueLengthLimit = int.MaxValue;
                o.MultipartBodyLengthLimit = long.MaxValue; // <-- !!! long.MaxValue
                o.MultipartBoundaryLengthLimit = int.MaxValue;
                o.MultipartHeadersCountLimit = int.MaxValue;
                o.MultipartHeadersLengthLimit = int.MaxValue;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }            
            
            app.UseRouting();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default",
                    "{controller=Home}/{action=index}/{id?}");
            });
        }
    }
}

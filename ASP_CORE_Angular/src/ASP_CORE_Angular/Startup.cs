using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ASP_CORE_Angular
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            /*
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("<html><body>");
                await context.Response.WriteAsync("<div>Inside middleware defined using app.Use</div>");
                await next();
                await context.Response.WriteAsync("</body></html>");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("<div>Another Middleware defined using app.Use</div>");
                await next();
            });

            app.Run(async context => {
                await context.Response.WriteAsync("<div>Inside middleware defined using app.Run</div>");
            });
            */
            /*
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            */

            app.UseStaticFiles();
        }
    }
}

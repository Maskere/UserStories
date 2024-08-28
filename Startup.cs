using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace UserStories
{
    public class Startup
    {
        public Startup(IConfiguration configuration){
            Configuration = configuration;
        }
        public IConfiguration Configuration {get;}

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
            if(env.IsDevelopment()){
                app.UseDeveloperExceptionPage();
            }
            else{
                app.UseExceptionHandler("/Error");

                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                    endpoints.MapRazorPages();
                    });
        }
        public void ConfigureServices(IServiceCollection services){
            services.AddRazorPages();

            services.AddSingleton<UserStoryService, UserStoryService>();
        }
    }
}

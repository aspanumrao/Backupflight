using Flight.Service.BookingAPI.DBContext;
using Flight.Service.BookingAPI.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight.Service.BookingAPI
{
    public class Startup
    {
        public Startup(IConfiguration _config)
        {
            Configuration = _config;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<BookingDbContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("FlightBookingDBConnection")));
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddMvc();
            services.AddCors();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors(Options =>
              Options.WithOrigins("http://localhost:4500")
              .AllowAnyMethod()
              .AllowAnyHeader()
              );
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvcWithDefaultRoute();
            app.UseMvc();
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApplication.Common;
using WebApplication.Domain;
using WebApplication.Domain.Model;
using WebApplication.Presentation.Mapper;
using WebApplication.Presentation.Model;

namespace WebApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.Add(new ServiceDescriptor(typeof(IGetCharacterByIdUseCase), new GetCharacterByIdUseCaseMock()));
            services.Add(new ServiceDescriptor(typeof(IGetCharactersUseCase), new GetCharactersUseCaseMock()));
            services.Add(new ServiceDescriptor(typeof(AbstractMapper<Character, CharacterDto>), new CharacterToCharacterDtoMapper()));
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}
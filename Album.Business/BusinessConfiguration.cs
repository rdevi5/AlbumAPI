
using Album.Business.AlbumBusiness;
using Album.Business.Mappers;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Album.Business
{
    public static class BusinessConfiguration
    {
        public static IServiceCollection AddBusinessConfiguration(this IServiceCollection services)
        {            
            services.AddScoped<IAlbumBL, AlbumBL>();
            AddMapperConfiguration(services);
            return services;
        }

        private static void AddMapperConfiguration(IServiceCollection services)
        {
            var mapperconfig = new MapperConfiguration(m =>
            {
                m.AddProfile(new AlbumProfile());

            });

            services.AddSingleton<IMapper>(o => mapperconfig.CreateMapper());
        }

    }
}
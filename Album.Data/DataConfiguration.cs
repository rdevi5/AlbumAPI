using Album.Data.IRepositories;
using Album.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Album.Data
{
    public static class DataConfiguration
    {
        public static IServiceCollection AddDataConfiguration(this IServiceCollection services)
        {           
            services.AddScoped<IAlbumRepository, AlbumRepository>();
            services.AddScoped<ITrackRepository, TrackRepository>();
            return services;
        }

    }
}

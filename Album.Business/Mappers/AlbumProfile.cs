using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Album.Data.Models;
using Album.Business.Model;

namespace Album.Business.Mappers
{
    public class AlbumProfile : Profile
    {
        public AlbumProfile() {
                       
            CreateMap<Data.Models.Album, AlbumDto>()
               .ForMember(dest => dest.AlbumId, o => o.MapFrom<int>(m => m.AlbumId))
               .ForMember(dest => dest.AlbumName, o => o.MapFrom<string>(m => m.Title));

            CreateMap<AlbumDto,Data.Models.Album>()
               .ForMember(dest => dest.AlbumId, o => o.MapFrom<int>(m => m.AlbumId))
               .ForMember(dest => dest.Title, o => o.MapFrom<string>(m => m.AlbumName));            

            CreateMap<ArtistAlbumTracks,TrackDto>()
               .ForMember(dest => dest.AlbumId, o => o.MapFrom<int>(m => m.AlbumId))
               .ForMember(dest => dest.AlbumName, o => o.MapFrom<string>(m => m.AlbumName))
               .ForMember(dest => dest.TrackName, o => o.MapFrom<string>(m => m.TrackName));
        }
    }
}

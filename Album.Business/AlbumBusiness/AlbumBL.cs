using Album.Data.IRepositories;
using Album.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Album.Data.Configurations;
using Album.Business.Model;
using AutoMapper;
using Album.Data.Models;

namespace Album.Business.AlbumBusiness
{
    public class AlbumBL : IAlbumBL
    {
        private readonly IAlbumRepository albumRepository;
        private readonly ITrackRepository trackRepository;
        private readonly IMapper _mapper;

        public AlbumBL(IAlbumRepository albumRepository, ITrackRepository trackRepository, IMapper mapper)
        {
            this.albumRepository = albumRepository;
            this.trackRepository = trackRepository;
            this._mapper = mapper;
        }

        public async Task<List<AlbumDto>> GetAllAlbums(CancellationToken cancellationToken = default)
        {
            return _mapper.Map<List<AlbumDto>>(await albumRepository.GetAlbumNames(cancellationToken));            
        }

        public async Task<bool> UpdateAlbum(AlbumDto albumDto, CancellationToken cancellationToken = default)
        {
            return await albumRepository.UpdateAlbumName(_mapper.Map<Data.Models.Album>(albumDto), cancellationToken);
        }

        public async Task<List<TrackDto>> GetAlbumTrack(List<AlbumDto> albumDto, CancellationToken cancellationToken = default)
        {
            var mapAlbum = _mapper.Map<List<Data.Models.Album>>(albumDto);
            return _mapper.Map<List<TrackDto>>(await trackRepository.GetAlbumTrack(mapAlbum, cancellationToken));            
        }
    }
}

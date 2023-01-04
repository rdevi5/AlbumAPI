using Album.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Album.Business.AlbumBusiness
{
    public interface IAlbumBL
    {
        Task<List<AlbumDto>> GetAllAlbums(CancellationToken cancellationToken = default);
        Task<bool> UpdateAlbum(AlbumDto albumDto, CancellationToken cancellationToken = default);
        Task<List<TrackDto>> GetAlbumTrack(List<AlbumDto> albumDto, CancellationToken cancellationToken = default);
    }
}

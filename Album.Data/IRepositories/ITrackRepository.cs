using Album.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Album.Data.IRepositories
{
    public interface ITrackRepository
    {
        Task<List<ArtistAlbumTracks>> GetAlbumTrack(List<Data.Models.Album> album, CancellationToken cancellationToken = default);
    }
}

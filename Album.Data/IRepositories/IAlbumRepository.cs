using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Album.Data.IRepositories
{
    public interface IAlbumRepository
    {
        Task<List<Album.Data.Models.Album>> GetAlbumNames(CancellationToken cancellationToken = default);
        Task<bool> UpdateAlbumName(Models.Album album, CancellationToken cancellationToken = default);        
    }
}

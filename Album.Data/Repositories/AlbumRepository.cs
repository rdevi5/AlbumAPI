using Album.Data.IRepositories;
using Album.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Album.Data.Repositories
{
    public class AlbumRepository : BaseReporitory<Album.Data.Models.Album>, IAlbumRepository
    {
        private readonly ChinookContext chinookContext;

        public AlbumRepository(ChinookContext chinookContext) : base(chinookContext)
        {
            this.chinookContext = chinookContext;
        }

        public async Task<List<Models.Album>> GetAlbumNames(CancellationToken cancellationToken = default)
        {
            return await chinookContext.Album.AsNoTracking()
                                       .Select(x => new Models.Album() { Title = x.Title, AlbumId = x.AlbumId }).ToListAsync(cancellationToken);            
        }

        public async Task<bool> UpdateAlbumName(Models.Album album, CancellationToken cancellationToken = default)
        {
            
            var data = chinookContext.Album.FirstOrDefault(x => x.AlbumId == album.AlbumId);
            if (data != null) { 
                data.Title = album.Title;
                chinookContext.Album.Update(data);
                var result = await chinookContext.SaveChangesAsync();
                return true;
            }
            return false;
        }      
    }
}

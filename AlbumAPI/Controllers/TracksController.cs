using Album.Business.AlbumBusiness;
using Album.Business.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlbumAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TracksController : ControllerBase
    {
        private readonly IAlbumBL albumBL;

        public TracksController(IAlbumBL albumBL)
        {
            this.albumBL = albumBL;
        }

        [HttpPost]        
        public async Task<IActionResult> Post(List<AlbumDto> albumDto, CancellationToken cancellationToken)
        {
            return Ok(await albumBL.GetAlbumTrack(albumDto, cancellationToken));
        }
    }
}

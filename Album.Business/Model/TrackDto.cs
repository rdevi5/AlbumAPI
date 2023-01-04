using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Album.Business.Model
{
    public class TrackDto
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; } = String.Empty;
        public string TrackName { get; set; } = String.Empty;
    }
}

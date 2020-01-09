
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespace
using ChinookSystem.Data.POCO;
#endregion

namespace ChinookSystem.Data.DTO
{
    public class ArtisAlbumList
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
        List<ListDLL> AlbumList { get; set; }
    }
}

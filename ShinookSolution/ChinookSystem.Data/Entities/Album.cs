using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

namespace ChinookSystem.Data.Entities
{
    [Table("Albums")]
    public class Album
    {
        private string _ReleaseLabel;
        [Key]
        public int AlbumId { get; set; }
        [StringLength(160,ErrorMessage ="Maximum charcters for title is 160")]
        public string Title { get; set; }
        public int ArtistId { get; set; }
        public int ReleaseYear { get; set; }
        [StringLength(50,ErrorMessage ="Maximum Characters for release label is 50")]
        public string ReleaseLabel {
            get
            {
                return _ReleaseLabel;
            }
            set
            {
                _ReleaseLabel = string.IsNullOrEmpty(value) ? null : value;
            }
        }
        public virtual Artist Artist { get; set; }
        //public virtual ICollection<Track> Tracks { get; set; }
    }
}

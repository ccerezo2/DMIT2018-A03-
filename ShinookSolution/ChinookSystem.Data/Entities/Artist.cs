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
    //first identify the SQL entity ((Table) this class maps.
    [Table("Artists")]
    public class Artist /*(this is a singlular)*/
    {
        //Fully implemented properties will be used for nullable strings
        private string _Name;
        [Key]
        public int ArtistId { get; set; }
        [StringLength(120, ErrorMessage = "Artist name is limited to 120characters only")]
        public string Name {
            get
            {
                return _Name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _Name = null;
                }
                else
                {
                    _Name = value;
                }
            }
        }
        //virtual navigation properties
        //these properties do not contain data
        //these properties form a virtual relationship
        //  between the entitity classes
        //You create the appropriate virtual properties such
        //  as you are mapping the ERD that
        //  exists in your database
        public virtual ICollection<Album> Albums {get;set;}
    }
}

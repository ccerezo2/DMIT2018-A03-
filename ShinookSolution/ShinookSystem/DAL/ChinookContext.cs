using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
using ChinookSystem.Data.Entities;
#endregion

namespace ShinookSystem.DAL
{
    internal class ChinookContext:DbContext
    {
        //the constructor is used to pass the connection string name
        //  to the DBcontext class
        public ChinookContext():base("ChinookDB")
        {

        }
        //..Setup the properties for the DbSet<> used
        // to acess the sql data
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        //DTOS and POCOS dont represent or get DbSet properties/ Only entities( which wwere the table and such)
    }
}

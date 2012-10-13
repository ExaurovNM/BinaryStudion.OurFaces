using System.Data.Entity;
using BinariStudion.OurFaces.Core.DomainModels;

namespace BinariStudion.OurFaces.Core.DataAccess
{
    class DataBaseContext : DbContext 
    {
        public IDbSet<User> Users { get; set; }

        public IDbSet<Face> Faces { get; set; } 
    }
}

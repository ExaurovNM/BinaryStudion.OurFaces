using System.Data.Entity;
using BinariStudion.OurFaces.Core.DomainModels;

namespace BinariStudion.OurFaces.Core.DataAccess
{
    public class DataBaseContext : DbContext 
    {
        public IDbSet<User> Users { get; set; }

        public IDbSet<Face> Faces { get; set; } 

        // maping
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasOptional(x => x.Face).WithRequired(x => x.User);

            base.OnModelCreating(modelBuilder);
        }
    }
}

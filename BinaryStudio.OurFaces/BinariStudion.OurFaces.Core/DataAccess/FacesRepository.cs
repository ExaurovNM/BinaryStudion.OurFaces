using System;
using System.Data;
using System.Linq;
using BinariStudion.OurFaces.Core.DomainModels;

namespace BinariStudion.OurFaces.Core.DataAccess
{
    public class FacesRepository : IFacesRepository
    {
        private readonly DataBaseContext context;

        public FacesRepository(DataBaseContext context)
        {
            this.context = context;
        }

        public void Add(Face face)
        {
            context.Faces.Add(face);
            context.SaveChanges();
        }
    }
}
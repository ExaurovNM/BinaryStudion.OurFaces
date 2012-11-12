using System.Collections.Generic;
using System.Linq;
using System.Text;
using BinariStudion.OurFaces.Core.DomainModels;

namespace BinariStudion.OurFaces.Core.DataAccess
{
    public interface IFacesRepository
    {
        void Add(Face face);
    }
}

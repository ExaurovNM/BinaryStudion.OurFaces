using System.Collections.Generic;
using System.Linq;
using System.Text;
using BinariStudion.OurFaces.Core.DomainModels;

namespace BinariStudion.OurFaces.Core.DataAccess
{
    public interface IUserRepository
    {
        bool ValidateUser(string userName, string hashedPassword);
        void CreateUser(string userName, string password);
        Employee Get(string userName);
    }
}

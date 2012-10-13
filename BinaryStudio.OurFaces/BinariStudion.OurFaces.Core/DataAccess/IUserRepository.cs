using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinariStudion.OurFaces.Core.DataAccess
{
    public interface IUserRepository
    {
        bool ValidateUser(string userName, string hashedPassword);
        void CreateUser(string userName, string password);
    }
}

using BinariStudion.OurFaces.Core.DomainModels;

namespace BinaryStudio.OurFaces.Security
{
    public interface  IAuthService
    {
        Employee GetAuthenticatedUser();

        bool ValidateUser(string userName, string password);

        void LogOn(string userName, bool remember);

        void LogOff();
    }
}
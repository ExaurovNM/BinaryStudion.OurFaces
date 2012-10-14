using Microsoft.VisualBasic.ApplicationServices;

namespace BinaryStudio.OurFaces.Security
{
    public interface  IAuthService
    {
        User GetAuthenticatedUser();

        bool ValidateUser(string userName, string password);

        void LogOn(string userName, bool remember);

        void LogOff();
    }
}
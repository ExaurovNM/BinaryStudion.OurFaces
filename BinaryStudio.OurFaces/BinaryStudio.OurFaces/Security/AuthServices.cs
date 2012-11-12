using System;
using System.Web;
using System.Web.Security;
using BinariStudion.OurFaces.Core.DataAccess;
using BinariStudion.OurFaces.Core.DomainModels;
using BinaryStudio.OurFaces.Common.Utility;

namespace BinaryStudio.OurFaces.Security
{
    public class AuthServices : IAuthService
    {
        private readonly IUserRepository userRepository;
        private readonly IHashProvider hashProvider;

        public AuthServices(IUserRepository userRepository, IHashProvider hashProvider)
        {
            this.userRepository = userRepository;
            this.hashProvider = hashProvider;
        }

        public Employee GetAuthenticatedUser()
        {
            var userName = HttpContext.Current.User.Identity.Name;
            return userRepository.Get(userName);
        }

        public bool ValidateUser(string userName, string password)
        {
            var hashedPassword = this.hashProvider.ComputePasswordHash(userName, password);
            return this.userRepository.ValidateUser(userName, hashedPassword);
        }

        public void LogOn(string userName, bool remember)
        {
            FormsAuthentication.SetAuthCookie(userName, remember);
        }

        public void LogOff()
        {
            FormsAuthentication.SignOut();
        }
    }
}
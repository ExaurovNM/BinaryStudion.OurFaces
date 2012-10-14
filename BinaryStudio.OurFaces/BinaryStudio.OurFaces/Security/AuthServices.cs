using System;
using System.Web.Security;
using BinariStudion.OurFaces.Core.DataAccess;
using BinaryStudio.OurFaces.Common.Utility;
using Microsoft.VisualBasic.ApplicationServices;

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

        public User GetAuthenticatedUser()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
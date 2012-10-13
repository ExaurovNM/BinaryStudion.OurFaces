using System;
using System.Linq;
using BinariStudion.OurFaces.Core.DomainModels;
using BinaryStudio.OurFaces.Common.Utility;

namespace BinariStudion.OurFaces.Core.DataAccess
{
    public class UserRepository  : IUserRepository
    {
        private readonly DataBaseContext context;
        private readonly IHashProvider hashProvider;

        public UserRepository(DataBaseContext context, IHashProvider hashProvider)
        {
            this.context = context;
            this.hashProvider = hashProvider;
        }

        public bool ValidateUser(string userName, string hashedPassword)
        {
            var user = this.context.Users.FirstOrDefault(x => x.UserName == userName && x.Password == hashedPassword);
            
            return user != null;
        }

        public void CreateUser(string userName, string password)
        {
            var user = new User
                           {
                               UserName = userName, 
                               Password = this.hashProvider.ComputePasswordHash(userName, password),
                               Id = Guid.NewGuid()
                           };

            this.context.Users.Add(user);
            this.context.SaveChanges();
        }
    }
}
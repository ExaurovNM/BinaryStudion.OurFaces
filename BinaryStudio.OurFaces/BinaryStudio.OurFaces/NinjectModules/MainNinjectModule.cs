using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BinariStudion.OurFaces.Core.DataAccess;
using BinaryStudio.OurFaces.Common.Utility;
using BinaryStudio.OurFaces.Security;
using Ninject.Modules;
using Ninject.Web.Common;

namespace BinaryStudio.OurFaces.NinjectModules
{
    public class MainNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IAuthService>().To<AuthServices>().InRequestScope();
            this.Bind<IUserRepository>().To<UserRepository>().InRequestScope();
            this.Bind<IHashProvider>().To<HashProvider>().InRequestScope();
        }
    }
}
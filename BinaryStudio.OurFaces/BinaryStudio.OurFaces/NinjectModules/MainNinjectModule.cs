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
            Bind<IAuthService>().To<AuthServices>().InRequestScope();
            Bind<IUserRepository>().To<UserRepository>().InRequestScope();
            Bind<IHashProvider>().To<HashProvider>().InRequestScope();
            Bind<IFacesRepository>().To<FacesRepository>().InRequestScope();
        }
    }
}
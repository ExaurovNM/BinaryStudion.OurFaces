using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BinariStudion.OurFaces.Core.DataAccess;
using BinaryStudio.OurFaces.Models;

namespace BinaryStudio.OurFaces.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserRepository userRepository;

        public AccountController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        public ActionResult Register()
        {
            var model = new RegisterModel();
            return this.View(model);
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                this.userRepository.CreateUser(model.UserName, model.Password);
            }
            return this.View(model);
        }
    }
}

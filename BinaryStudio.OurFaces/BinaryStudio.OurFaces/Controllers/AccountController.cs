using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BinariStudion.OurFaces.Core.DataAccess;
using BinaryStudio.OurFaces.Models;
using BinaryStudio.OurFaces.Security;

namespace BinaryStudio.OurFaces.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserRepository userRepository;
        private readonly IAuthService authService;

        private const string KEY_NEW_USERNAME = "username";

        public AccountController(IUserRepository userRepository, IAuthService authService)
        {
            this.userRepository = userRepository;
            this.authService = authService;
        }

        #region Register
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
                this.authService.LogOn(model.UserName, remember: true);
                TempData.Add(KEY_NEW_USERNAME, model.UserName);

                return this.RedirectToAction("Greeting");
            }

            return this.View(model);
        }
        #endregion

        #region Logon
        [HttpGet]
        public ActionResult LogOn()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult LogOn(LogonModel model)
        {
            if (ModelState.IsValid)
            {
                if (this.authService.ValidateUser(model.UserName, model.Password))
                {
                    this.authService.LogOn(model.UserName, model.Remember);
                    return this.RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Password or UserName invalid.");
                return this.View(model);
            }

            return this.View(model);
        }
        #endregion

        [HttpGet]
        public ActionResult Greeting()
        {
            var name = this.TempData[KEY_NEW_USERNAME].ToString();
            var model = new GreetingModel
                            {
                                Name = name
                            };

            return this.View(model);
        }
       
    }

    public class GreetingModel
    {
        public string Name { get; set; }
    }
}

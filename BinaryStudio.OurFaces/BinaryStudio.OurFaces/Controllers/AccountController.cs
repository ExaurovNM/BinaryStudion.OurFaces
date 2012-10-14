using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public AccountController(IUserRepository userRepository, IAuthService authService)
        {
            this.userRepository = userRepository;
            this.authService = authService;
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
                if (this.userRepository.ValidateUser(model.UserName, model.Password))
                {
                    this.authService.LogOn(model.UserName, model.Remember);
                }

                ModelState.AddModelError("", "Password or UserName invalid.");
                return this.View(model);
            }

            return this.View(model);
        }
    }

    public class LogonModel
    {
        [Required(ErrorMessage = "Hmmm... who are you?")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "What about password?")]
        public string Password { get; set; }

        public bool Remember { get; set; }
    }
}

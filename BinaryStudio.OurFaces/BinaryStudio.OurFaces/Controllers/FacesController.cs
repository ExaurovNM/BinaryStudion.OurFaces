using System;
using System.Data;
using System.Web.Mvc;
using BinariStudion.OurFaces.Core.DataAccess;
using BinariStudion.OurFaces.Core.DomainModels;
using BinaryStudio.OurFaces.Security;

namespace BinaryStudio.OurFaces.Controllers
{
    public class FacesController : Controller
    {
        private readonly IFacesRepository facesRepository;
        private readonly IAuthService authService;


        public FacesController(IFacesRepository facesRepository, IAuthService authService)
        {
            this.facesRepository = facesRepository;
            this.authService = authService;
        }

        [HttpGet]
        public ActionResult AddFace()
        {
            return View();
        }

        [HttpPost] 
        public ActionResult AddFace(AddFaceModel model)
        {
            if (ModelState.IsValid)
            {
                var user = authService.GetAuthenticatedUser();
                var domail = model.ToDomain(user.Id);
                facesRepository.Add(domail);
            }
            return View(model);
        }

    }

    public class AddFaceModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public string ContactPhone { get; set; }

        public string ContactSkype { get; set; }

        public string ContactEmail { get; set; }

        public Face ToDomain(Guid userId)
        {
            return new Face
                        {
                            EmployeeId = userId,
                            FirstName = FirstName,
                            LastName = LastName,
                            Birthday = Birthday,
                            ContactPhone = ContactPhone,
                            ContactSkype = ContactSkype,
                            ContactEmail = ContactEmail
                        };
        }
    }
}

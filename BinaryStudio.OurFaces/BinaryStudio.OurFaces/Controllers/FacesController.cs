using System;
using System.Data;
using System.Web.Mvc;

namespace BinaryStudio.OurFaces.Controllers
{
    public class FacesController : Controller
    {
        [HttpGet]
        public ActionResult AddFace()
        {
            return View();
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
    }
}

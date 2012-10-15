using System.ComponentModel.DataAnnotations;

namespace BinaryStudio.OurFaces.Models
{
    public class LogonModel
    {
        [Required(ErrorMessage = "Hmmm... who are you?")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "What about password?")]
        public string Password { get; set; }

        public bool Remember { get; set; }
    }
}
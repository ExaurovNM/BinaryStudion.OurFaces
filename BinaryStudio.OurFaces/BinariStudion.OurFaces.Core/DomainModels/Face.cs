using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BinariStudion.OurFaces.Core.DomainModels
{
    public class Face : BaseEntity
    {
        public virtual Employee Employee { get; set; }

        public Guid EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public string ContactPhone { get; set; }

        public string ContactSkype { get; set; }

        public string ContactEmail { get; set; }
    }
}

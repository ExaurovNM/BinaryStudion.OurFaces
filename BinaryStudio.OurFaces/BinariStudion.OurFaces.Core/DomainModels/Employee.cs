using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BinariStudion.OurFaces.Core.DomainModels
{
    public class Employee :BaseEntity
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public virtual Face Face { get; set; }

        public Guid? FaceId { get; set; }
    }
}

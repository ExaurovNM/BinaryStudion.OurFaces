using System;

namespace BinariStudion.OurFaces.Core.DomainModels
{
    public class User
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public virtual Face Face { get; set; }

        public Guid FaceId { get; set; }
    }
}

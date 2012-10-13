using System;

namespace BinariStudion.OurFaces.Core.DomainModels
{
    class User
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public Face Face { get; set; }

        public Guid FaceId { get; set; }
    }
}

using System;

namespace BinariStudion.OurFaces.Core.DomainModels
{
    class Face
    {
        public User User { get; set; }

        public Guid UserId { get; set; }

        public string FirstName { get; set; }
    }
}

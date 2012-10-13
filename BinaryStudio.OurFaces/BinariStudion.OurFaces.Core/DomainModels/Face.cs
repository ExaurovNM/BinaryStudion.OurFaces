using System;

namespace BinariStudion.OurFaces.Core.DomainModels
{
    public class Face
    {
        public Guid Id { get; set; }

        public virtual User User { get; set; }

        public Guid UserId { get; set; }

        public string FirstName { get; set; }
    }
}

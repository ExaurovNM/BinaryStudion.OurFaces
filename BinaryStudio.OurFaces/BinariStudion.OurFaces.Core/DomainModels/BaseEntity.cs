using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinariStudion.OurFaces.Core.DomainModels
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}

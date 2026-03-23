using System;
using System.Collections.Generic;
using System.Text;

namespace OpenEL
{
    public abstract class HALVariable
    {
        public abstract Guid Id { get; }
        public abstract HALId HALId { get; }
        public abstract byte[] Value { get; set; }
    }
}

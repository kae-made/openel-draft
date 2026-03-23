using System;
using System.Collections.Generic;
using System.Text;

namespace OpenEL
{
    public abstract class HALId
    {
        public abstract Guid deviceKindId { get; }
        public abstract Guid instanceId { get; }
        public abstract Guid productId { get; }
        public abstract Guid vendorId { get; }
    }
}

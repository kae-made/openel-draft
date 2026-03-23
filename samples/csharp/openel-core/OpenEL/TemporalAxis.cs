using System;
using System.Collections.Generic;
using System.Text;

namespace OpenEL
{
    public abstract class TemporalAxis
    {
        public abstract  Guid Id { get; }
        public abstract string Name { get; }
    }
}

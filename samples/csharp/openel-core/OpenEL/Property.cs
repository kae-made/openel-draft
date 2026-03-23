using System;
using System.Collections.Generic;
using System.Text;

namespace OpenEL
{
    public abstract class Property
    {
        public abstract string deviceName { get; }
        public abstract Dictionary<string, object> functionList { get; }
    }
}

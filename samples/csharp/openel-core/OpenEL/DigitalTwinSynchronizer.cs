using System;
using System.Collections.Generic;
using System.Text;

namespace OpenEL
{
    public class ValueChangedEventArgs : EventArgs
    {
        public HALVariable Variable { get; set; }
    }

    public interface DigitalTwinSynchronizer
    {
        ReturnCode Updated(HALVariable value);

        event EventHandler<ValueChangedEventArgs> ValueChanged;
    }
}

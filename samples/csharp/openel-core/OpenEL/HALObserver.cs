using System;
using System.Collections.Generic;
using System.Text;

namespace OpenEL
{
    public interface HALObserver
    {
        void notify_error(HALComponent source, int error_id);
        void notify_event(HALComponent source, int event_id);
    }
}

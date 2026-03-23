using System;
using System.Collections.Generic;

namespace OpenEL
{
    public abstract class HALComponent
    {
        public List<HALObserver> observerList { get => _observers;  }
        public abstract DateTime time { get; set; }

        public HALId id { get => _id ; }

        public TemporalAxis CurrentTemporalAxis { get => _temporalAxis; }
        public DigitalTwinSynchronizer Synchronizer { get => _synchronizer; }
        

        public abstract ReturnCode AddObserver(HALObserver target);
        public abstract ReturnCode Finalize();
        public abstract ReturnCode GetProperty(out Property property);
        public abstract ReturnCode Init();
        public abstract ReturnCode ReInit();
        public abstract ReturnCode RemoveObserver(HALObserver target);

        protected List<HALObserver> _observers = new List<HALObserver>();

        protected HALId _id;
        protected TemporalAxis _temporalAxis;
        protected DigitalTwinSynchronizer _synchronizer;

        protected HALComponent( HALId id, TemporalAxis temporalAxis, DigitalTwinSynchronizer synchronizer)
        {
            _id = id ?? throw new ArgumentNullException(nameof(id));
            _temporalAxis = temporalAxis ?? throw new ArgumentNullException(nameof(temporalAxis));
            _synchronizer = synchronizer ?? throw new ArgumentNullException(nameof(synchronizer));
        }
    }
}

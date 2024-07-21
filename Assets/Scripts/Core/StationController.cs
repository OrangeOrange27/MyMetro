using System;

namespace Core
{
    public class StationController : TravelComponentBase<StationData>
    {
        private int _maxPassengersCount;
        private int _passengersCount;

        public override void Initialize(StationData data)
        {
            base.Initialize(data);

            _maxPassengersCount = data.MaxPassengersCount;
        }
        
        public override void Dispose()
        {
            // TODO release managed resources here
        }
    }
}

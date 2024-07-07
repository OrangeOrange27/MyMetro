using Core;
using GameServices.Providers;

namespace GameServices.Factories
{
    public class PassengerFactory : TravelComponentFactoryBase<PassengerController, PassengerData>
    {
        public PassengerFactory(ITravelDataProvider<PassengerData> stationDataProvider,
            PassengerController stationPrefab) : base(stationDataProvider, stationPrefab)
        {
        }
    }
}
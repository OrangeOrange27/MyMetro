using Core;
using GameServices.Providers;
using Zenject;

namespace GameServices.Factories
{
    public class StationFactory : TravelComponentFactoryBase<StationController, StationData>
    {
        [Inject]
        public StationFactory(ITravelDataProvider<StationData> stationDataProvider, StationController stationPrefab) :
            base(stationDataProvider, stationPrefab)
        {
        }
    }
}
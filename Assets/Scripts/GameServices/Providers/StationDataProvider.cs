using Configs;
using Core;

namespace GameServices.Providers
{
    public class StationDataProvider : ITravelDataProvider<StationData>
    {
        private readonly StationsConfig _config;

        public StationDataProvider(StationsConfig config)
        {
            _config = config;
        }
        
        public StationData GetData()
        {
            var travelType = GetRandomTravelType();
            
            var data = new StationData()
            {
                TravelType = travelType,
                MaxPassengersCount = _config.MaxPassengersCount,
                Icon = _config.GetIcon(travelType)
            };
            
            return data;
        }

        private TravelType GetRandomTravelType()
        {
            return Utils.Utils.GetRandomValueFromEnum<TravelType>();
        }
    }
}
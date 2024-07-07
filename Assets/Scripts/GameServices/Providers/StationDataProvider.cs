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
            var data = new StationData()
            {
                TravelType = GetRandomTravelType(),
                MaxPassengersCount = _config.MaxPassengersCount,
            };
            
            return data;
        }

        private TravelType GetRandomTravelType()
        {
            return Utils.Utils.GetRandomValueFromEnum<TravelType>();
        }
    }
}
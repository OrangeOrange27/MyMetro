using Configs;
using Core;

namespace GameServices.Providers
{
    public class PassengerDataProvider : ITravelDataProvider<PassengerData>
    {
        private readonly PassengersConfig _config;

        public PassengerDataProvider(PassengersConfig config)
        {
            _config = config;
        }
        
        public PassengerData GetData()
        {
            var travelType = GetRandomTravelType();
            
            var data = new PassengerData()
            {
                TravelType = travelType,
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
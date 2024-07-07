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
            var data = new PassengerData()
            {
                TravelType = GetRandomTravelType(),
            };
            
            return data;
        }

        private TravelType GetRandomTravelType()
        {
            return Utils.Utils.GetRandomValueFromEnum<TravelType>();
        }
    }
}
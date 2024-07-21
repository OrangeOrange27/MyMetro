using UnityEngine;

namespace Core
{
    public class PassengerData : ITravelData
    {
        public TravelType TravelType { get; set; }
        public Sprite Icon { get; set; }
    }
}
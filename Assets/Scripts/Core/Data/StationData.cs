using UnityEngine;

namespace Core
{
    public class StationData : ITravelData
    {
        public TravelType TravelType { get; set; }
        public Sprite Icon { get; set; }
        public int MaxPassengersCount { get; set; }
    }
}
using UnityEngine;

namespace Core
{
    public interface ITravelData
    {
        TravelType TravelType { get; set; }
        Sprite Icon { get; set; }
    }
}
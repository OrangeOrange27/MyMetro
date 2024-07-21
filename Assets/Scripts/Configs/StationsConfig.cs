using Core;
using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(fileName = "Stations Config", menuName = "Configs/New Stations Config")]
    public class StationsConfig : ScriptableObject
    {
        [SerializeField] private IconToTypeConfig _iconToTypeConfig;
        [SerializeField] private int _maxPassengersCount;

        public int MaxPassengersCount => _maxPassengersCount;

        public Sprite GetIcon(TravelType travelType)
        {
            if (_iconToTypeConfig.TryGetValue(travelType, out var icon) == false)
            {
                Debug.LogError($"[{nameof(StationsConfig)}] Could not get icon for type: {travelType}");
            }

            return icon;
        }
    }
}
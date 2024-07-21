using Core;
using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(fileName = "Passengers Config", menuName = "Configs/New Passengers Config")]
    public class PassengersConfig : ScriptableObject
    {
        [SerializeField] private IconToTypeConfig _iconToTypeConfig;
        
        public Sprite GetIcon(TravelType travelType)
        {
            if (_iconToTypeConfig.TryGetValue(travelType, out var icon) == false)
            {
                Debug.LogError($"[{nameof(PassengersConfig)}] Could not get icon for type: {travelType}");
            }

            return icon;
        }
    }
}
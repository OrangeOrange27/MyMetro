using UnityEngine;

namespace Configs
{
    public class StationsConfig : ScriptableObject
    {
        [SerializeField] private int _maxPassengersCount;

        public int MaxPassengersCount => _maxPassengersCount;
    }
}
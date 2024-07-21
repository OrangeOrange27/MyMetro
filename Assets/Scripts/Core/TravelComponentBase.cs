using System;
using UnityEngine;
using UnityEngine.UI;

namespace Core
{
    public abstract class TravelComponentBase<TData> : MonoBehaviour, ISpawnable, IInitializable<TData>, IDisposable
        where TData : ITravelData
    {
        [SerializeField] protected Image _image;

        protected TravelType _travelType;

        public virtual void Initialize(TData data)
        {
            _travelType = data.TravelType;
            _image.sprite = data.Icon;
        }

        public virtual void Dispose()
        {
            // TODO release managed resources here
        }
    }
}
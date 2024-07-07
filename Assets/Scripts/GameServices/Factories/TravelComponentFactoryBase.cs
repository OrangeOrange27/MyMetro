using Core;
using GameServices.Providers;
using UnityEngine;
using Zenject;

namespace GameServices.Factories
{
    public abstract class TravelComponentFactoryBase<TComponent, TData> : IFactory<TComponent>
    where TData : ITravelData
    where TComponent : TravelComponentBase<TData>
    {
        private readonly ITravelDataProvider<TData> _dataProvider;
        private readonly TComponent _prefab;

        protected TravelComponentFactoryBase(ITravelDataProvider<TData> stationDataProvider, TComponent stationPrefab)
        {
            _dataProvider = stationDataProvider;
            _prefab = stationPrefab;
        }
        
        public TComponent Create()
        {
            var component = Object.Instantiate(_prefab);
            component.Initialize(_dataProvider.GetData());

            return component;
        }
    }
}
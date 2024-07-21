using Configs;
using GameServices.Factories;
using GameServices.Providers;
using UnityEngine;
using Zenject;

namespace Installers
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField] private StationsConfig _stationsConfig;
        [SerializeField] private PassengersConfig _passengersConfig;
        
        public override void InstallBindings()
        {
            Container.Bind<StationsConfig>().ToSelf().FromInstance(_stationsConfig).AsSingle();
            Container.Bind<PassengersConfig>().ToSelf().FromInstance(_passengersConfig).AsSingle();
            
            Container.BindInterfacesAndSelfTo<StationFactory>().FromNew().AsSingle();
            Container.BindInterfacesAndSelfTo<PassengerFactory>().FromNew().AsSingle();
            
            Container.Bind<StationDataProvider>().ToSelf().FromNew().AsSingle();
            Container.Bind<PassengerDataProvider>().ToSelf().FromNew().AsSingle();
        }
    }
}
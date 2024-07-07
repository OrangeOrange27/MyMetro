using Configs;
using GameServices.Factories;
using UnityEngine;
using Zenject;

namespace Installers
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField] private StationsConfig _stationsConfig;
        
        public override void InstallBindings()
        {
            Container.Bind<StationsConfig>().ToSelf().FromInstance(_stationsConfig).AsSingle();
            
            Container.BindInterfacesAndSelfTo<StationFactory>().FromNew().AsSingle();
        }
    }
}
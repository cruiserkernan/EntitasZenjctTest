using System;
using Entitas;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller<GameInstaller>
{
    public override void InstallBindings()
    {
        Container.Bind<ILoggerService>().To<LogService>().AsSingle();
    }
}
using Zenject;
using UnityEngine;

public class MenuInstaller : MonoInstaller
{
    [SerializeField]
    private ScreenProvider _screenProvider;

    public override void InstallBindings()
    {
        Container.Bind<ScreenProvider>().FromInstance(_screenProvider);
        Container.Bind<ScreenNavigator>().AsSingle();

        Container.Bind<GameLoadingRepository>().AsSingle().NonLazy();
        Container.Bind<SplashTextRepository>().AsSingle();

        Container.Bind<SplashScreenController>().AsTransient();
        Container.Bind<MainMenuController>().AsTransient();
        Container.Bind<SettingsScreenController>().AsTransient();
    }
}

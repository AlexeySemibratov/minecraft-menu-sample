using Zenject;
using UnityEngine;

public class MenuInstaller : MonoInstaller
{
    [SerializeField]
    private ScreenProvider _screenProvider;

    [SerializeField]
    private PanoramaCamera _panoramaCamera;

    public override void InstallBindings()
    {
        Container.Bind<ScreenProvider>().FromInstance(_screenProvider);
        Container.Bind<ScreenNavigator>().AsSingle();
        Container.Bind<PanoramaCamera>().FromInstance(_panoramaCamera);

        Container.Bind<GameLoadingRepository>().AsSingle().NonLazy();
        Container.Bind<SplashTextRepository>().AsSingle();

        Container.Bind<SplashScreenController>().AsTransient();
        Container.Bind<MainMenuController>().AsTransient();
        Container.Bind<SettingsScreenController>().AsTransient();
    }
}

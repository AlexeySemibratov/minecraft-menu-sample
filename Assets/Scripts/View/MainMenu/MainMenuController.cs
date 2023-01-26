using System.Collections.Generic;
using System.Linq;
using Random = System.Random;

public class MainMenuController : ViewController<MainMenuView>
{
    private SplashTextRepository _splashTextRepository;
    private ScreenNavigator _screenNavigator;
    private PanoramaCamera _panoramaCamera;

    public MainMenuController(SplashTextRepository splashTextRepository, 
        ScreenNavigator screenNavigator,
        PanoramaCamera panoramaCamera)
    {
        _splashTextRepository = splashTextRepository;
        _screenNavigator = screenNavigator;
        _panoramaCamera = panoramaCamera;
    }

    protected override void OnViewAttached()
    {
        base.OnViewAttached();

        ShowRandomSplash();
        StartPanorama();
    }

    public void OnSettingsClicked()
    {
        _screenNavigator.NavigateTo(ScreenType.Settings);
    }

    public void OnQuitClicked()
    {
        _screenNavigator.Exit();
    }

    private void ShowRandomSplash()
    {
        IEnumerable<string> splashes = _splashTextRepository.GetSplashes();
        var index = new Random().Next(0, splashes.Count());
        string randomSplash = splashes.ElementAt(index);

        _view.ShowSplashText(randomSplash);
    }

    private void StartPanorama()
    {
        _panoramaCamera.StartRotation();
    }

    private void StopPanorama()
    {
        _panoramaCamera.StopRotation();
    }
}

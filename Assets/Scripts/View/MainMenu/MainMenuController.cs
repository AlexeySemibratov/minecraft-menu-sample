using System.Collections.Generic;
using System.Linq;
using Random = System.Random;

public class MainMenuController : ViewController<MainMenuView>
{
    private SplashTextRepository _splashTextRepository;
    private ScreenNavigator _screenNavigator;

    public MainMenuController(SplashTextRepository splashTextRepository, ScreenNavigator screenNavigator)
    {
        _splashTextRepository = splashTextRepository;
        _screenNavigator = screenNavigator;
    }

    protected override void OnViewAttached()
    {
        base.OnViewAttached();

        ShowRandomSplash();
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
}

public class SettingsScreenController : ViewController<SettingsScreenView>
{
    private ScreenNavigator _screenNavigator;

    public SettingsScreenController(ScreenNavigator screenNavigator)
    {
        _screenNavigator = screenNavigator;
    }

    public void OnDoneClicked()
    {
        _screenNavigator.NavigateTo(ScreenType.Menu);
    }
}

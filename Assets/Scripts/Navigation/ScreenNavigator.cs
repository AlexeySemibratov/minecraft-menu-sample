using UnityEngine;

public class ScreenNavigator
{
    private ScreenProvider _screenProvider;

    private GameObject _currentScreen;

    public ScreenNavigator(ScreenProvider screenProvider)
    {
        _screenProvider = screenProvider;
    }

    public void NavigateTo(ScreenType screen)
    {
        if (_currentScreen != null)
        {
            _currentScreen.SetActive(false);
        }

        GameObject newScreen = _screenProvider.GetScreen(screen);

        _currentScreen = newScreen;
        _currentScreen.SetActive(true);
    }

    public void Exit()
    {
#if UNITY_STANDALONE
        Application.Quit();
#endif
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}

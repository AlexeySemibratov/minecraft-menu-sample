using UnityEngine;
using Zenject;

public class GameStartup : MonoBehaviour
{
    [Inject]
    private ScreenNavigator _screenNavigator;

    private void Awake()
    {
        _screenNavigator.NavigateTo(ScreenType.Splash);
    }
}

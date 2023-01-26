using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScreenProvider : MonoBehaviour
{
    [SerializeField]
    private List<Screen> _screens;

    public GameObject GetScreen(ScreenType type)
    {
        return _screens
            .First(screen => screen.Type == type)
            .ScreenObject;
    }
}

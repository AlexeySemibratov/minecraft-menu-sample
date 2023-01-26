using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class SettingsScreenView : View<SettingsScreenView, SettingsScreenController>, IView
{
    protected override SettingsScreenView view => this;

    [SerializeField]
    private Button _doneButton;

    private void Awake()
    {
        SetupButtons();
    }

    private void SetupButtons()
    {
        _doneButton.onClick.AddListener(() => _controller.OnDoneClicked());
    }
}

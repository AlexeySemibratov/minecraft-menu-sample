using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class SettingsScreenView : MonoBehaviour
{
    [SerializeField]
    private Button _doneButton;

    [Inject]
    private SettingsScreenController _controller;

    private void Awake()
    {
        SetupButtons();
    }

    private void OnEnable()
    {
        _controller.AttachView(this);
    }

    private void SetupButtons()
    {
        _doneButton.onClick.AddListener(() => _controller.OnDoneClicked());
    }
}

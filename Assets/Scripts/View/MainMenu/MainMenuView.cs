using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class MainMenuView : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _splashText;

    [SerializeField]
    private Button _singleplayerButton;

    [SerializeField]
    private Button _multiplayerButton;

    [SerializeField]
    private Button _settingsButton;

    [SerializeField]
    private Button _quitButton;

    [Inject]
    private MainMenuController _controller;

    private void Awake()
    {
        SetupButtons();
        AnimateSplashText();
    }

    private void OnEnable()
    {
        _controller.AttachView(this);
    }

    public void ShowSplashText(string text)
    {
        _splashText.text = text;
    }

    private void SetupButtons()
    {
        _settingsButton.onClick.AddListener(() => _controller.OnSettingsClicked());
        _quitButton.onClick.AddListener(() => _controller.OnQuitClicked());
    }

    private void AnimateSplashText()
    {
        Transform textTransform = _splashText.transform;
        Vector3 originalScale = textTransform.localScale;

        DOTween.Sequence()
            .Append(textTransform.DOScale(originalScale * 1.2f, 0.5f))
            .SetLink(gameObject)
            .SetLoops(-1, LoopType.Yoyo);
    }
}

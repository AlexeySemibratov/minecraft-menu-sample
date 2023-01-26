using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : View<MainMenuView, MainMenuController>, IView
{
    protected override MainMenuView view => this;

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

    private void Awake()
    {
        base.Awake();

        SetupButtons();
        AnimateSplashText();
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

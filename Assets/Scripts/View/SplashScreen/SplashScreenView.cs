using DG.Tweening;
using TMPro;
using UnityEngine;

public class SplashScreenView : View<SplashScreenView, SplashScreenController>, IView
{
    protected override SplashScreenView view => this;

    private const string ProgressText = "{0} %";
    private const int MaxPercent = 100;

    private const float ProgressAnimationDuration = 1.5f;

    [SerializeField]
    private ProgressBar _progressBar;

    [SerializeField]
    private TextMeshProUGUI _progressText;

    private Tween _progressTween;

    protected void Awake()
    {
        base.Awake();

        _progressBar.Progress = 0;
    }

    public void ShowProgress(float value)
    {
        if (_progressTween != null)
            _progressTween.Kill();

        _progressTween = DOTween.To(
            () => _progressBar.Progress,
            x => UpdateProgressValues(x),
            value,
            ProgressAnimationDuration)
            .SetEase(Ease.OutCirc)
            .SetLink(gameObject);
    }

    private void UpdateProgressValues(float value)
    {
        _progressBar.Progress = value;
        _progressText.text = string.Format(ProgressText, (int)(value * MaxPercent));
    }
}

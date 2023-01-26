using TMPro;
using UnityEngine;

public class SplashScreenView : View<SplashScreenView, SplashScreenController>, IView
{
    protected override SplashScreenView view => this;

    private const string ProgressText = "{0} %";
    private const int MaxPercent = 100;

    [SerializeField]
    private ProgressBar _progressBar;

    [SerializeField]
    private TextMeshProUGUI _progressText;

    public void ShowProgress(float value)
    {
        _progressBar.SetProgress(value);
        _progressText.text = string.Format(ProgressText, (int) (value * MaxPercent));
    }
}

using TMPro;
using UnityEngine;
using Zenject;

public class SplashScreenView : MonoBehaviour
{
    private const string ProgressText = "{0} %";
    private const int MaxPercent = 100;

    [SerializeField]
    private ProgressBar _progressBar;

    [SerializeField]
    private TextMeshProUGUI _progressText;

    [Inject]
    private SplashScreenController _controller;

    private void OnEnable()
    {
        _controller.AttachView(this);
    }

    public void ShowProgress(float value)
    {
        _progressBar.SetProgress(value);
        _progressText.text = string.Format(ProgressText, (int) (value * MaxPercent));
    }
}

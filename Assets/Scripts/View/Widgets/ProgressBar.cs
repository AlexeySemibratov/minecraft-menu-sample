using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private const float MinProgress = 0.0f;
    private const float MaxProgress = 1.0f;

    [SerializeField]
    private Image _foregroundImage;

    public void SetProgress(float value)
    {
        _foregroundImage.fillAmount = Mathf.Clamp(value, MinProgress, MaxProgress);
    }
}

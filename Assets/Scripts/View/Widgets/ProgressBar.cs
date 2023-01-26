using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public float Progress { 
        get => _foregroundImage.fillAmount; 
        set => _foregroundImage.fillAmount = Mathf.Clamp(value, MinProgress, MaxProgress); }

    private const float MinProgress = 0.0f;
    private const float MaxProgress = 1.0f;

    [SerializeField]
    private Image _foregroundImage;
}

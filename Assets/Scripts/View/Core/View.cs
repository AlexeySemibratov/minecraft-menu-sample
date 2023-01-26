using UnityEngine;
using Zenject;

public abstract class View<TView, TController> : MonoBehaviour
    where TController : ViewController<TView>
    where TView : IView
{
    protected abstract TView view { get; }

    [Inject]
    protected TController _controller;

    protected void Awake()
    {
        _controller.AttachView(view);
    }

    protected void OnEnable()
    {
        _controller.OnViewShow();
    }

    protected void OnDisable()
    {
        _controller.OnViewHide();
    }

    protected void OnDestroy()
    {
        _controller.OnViewDestroyed();
        _controller = null;
    }
}

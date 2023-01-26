public abstract class ViewController<V>
    where V : IView
{
    protected V _view;

    public void AttachView(V view)
    {
        _view = view;
        OnViewAttached();
    }

    public virtual void OnViewAttached()
    {

    }

    public virtual void OnViewShow()
    {

    }

    public virtual void OnViewHide()
    {

    }

    public virtual void OnViewDestroyed()
    {
        
    }
}

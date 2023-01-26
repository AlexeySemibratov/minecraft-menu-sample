public abstract class ViewController<V>
{
    protected V _view;

    public void AttachView(V view)
    {
        _view = view;
        OnViewAttached();
    }

    protected virtual void OnViewAttached()
    {

    }
}

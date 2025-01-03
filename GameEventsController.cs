using System;
public class GameEventsController
{
    public event Action baseEvent;
    public void InvokeEvent() => baseEvent?.Invoke();
    public void AddListner(Action listner) => baseEvent += listner;
    public void RemoveListner(Action listner) => baseEvent -= listner;
}
public class GameEventsController<T>
{
    public event Action<T> baseEvent;
    public void InvokEvent(T type) => baseEvent?.Invoke(type);
    public void AddListner(Action<T> listner) => baseEvent += listner;
    public void RemoveListner(Action<T> listner) => baseEvent -= listner;
}
    
Advance Generic Event System, to use it 
public GameEventsController OnGameStartEvent;



Example:
public class GameSerive: MonoBehhaviour
{
    public GameEventsController OnGameStartEvent;
    public GameEventsController<float> ScoreAdding;
    void Start()
    {
        OnGameStartEvent=new GameEventsController;
        ScoreAdding=new GameEventsController<float>;
    }
}
// GameStartEvent
public class EnemyAI: MonoBehhaviour
{
    void OnEnable()
    {
        GameSerive.Instance.OnGameStartEvent.AddListner(StartAI);
    }
    void OnDisable()
    {
        GameSerive.Instance.OnGameStartEvent.RemoveListner(StartAI);
    }
    void StartAI(){}
}

// Invoke
Simply Invoke
GameSerive.Instance.OnGameStartEvent.Invoke();
GameSerive.Instance.ScoreAdding.Invoke(4.5f);


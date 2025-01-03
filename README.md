Advance Generic Event System, to use it 


Example:
//Create

public GameEventsController OnGameStartEvent;

public GameEventsController<float> ScoreAdding;

//Initilizee 

OnGameStartEvent=new GameEventsController;

ScoreAdding=new GameEventsController<float>;

//Listner Add and Remove

GameSerive.Instance.OnGameStartEvent.AddListner(StartAI);

GameSerive.Instance.OnGameStartEvent.RemoveListner(StartAI);

//Invoke

GameSerive.Instance.OnGameStartEvent.Invoke();

GameSerive.Instance.ScoreAdding.Invoke(4.5f);

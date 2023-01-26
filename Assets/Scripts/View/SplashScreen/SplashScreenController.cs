using System.Threading.Tasks;

public class SplashScreenController : ViewController<SplashScreenView>
{
    private ScreenNavigator _navigator;

    private GameLoadingRepository _gameLoadingRepository;

    public SplashScreenController(ScreenNavigator navigator, GameLoadingRepository gameLoadingRepository)
    {
        _navigator = navigator;
        _gameLoadingRepository = gameLoadingRepository;
    }

    public override void OnViewAttached()
    {
        base.OnViewAttached();

        StartLoading();
    }

    private async void StartLoading()
    {
        await LoadGame();

        OpenMainMenu();
    }

    private async Task LoadGame()
    {
        _view.ShowProgress(0);

        int count = _gameLoadingRepository.GetTotalTaskCount();

        await _gameLoadingRepository.LoadGame((taskNum) => UpdateProgress(taskNum, count));
    }

    private void UpdateProgress(int lastTaskNumber, int taskCount)
    {
        float progress = (lastTaskNumber + 1) / (float)taskCount;
        _view.ShowProgress(progress);
    }

    private void OpenMainMenu()
    {
       _navigator.NavigateTo(ScreenType.Menu);
    }
}

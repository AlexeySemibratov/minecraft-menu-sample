using System;
using System.Threading.Tasks;

public class GameLoadingRepository
{
    private SplashTextRepository _splashTextRepository;

    private Random _random = new Random();

    public GameLoadingRepository(SplashTextRepository splashTextRepository)
    {
        _splashTextRepository = splashTextRepository;
    }

    public async Task LoadGame(Action<int> taskProgressCallback)
    {
        await _splashTextRepository.LoadSplashes();
        taskProgressCallback(0);

        // Emulate hard loading
        for (int i = 1; i < GetTotalTaskCount(); i++)
        {
            await Task.Delay(_random.Next(250, 1000));
            taskProgressCallback(i);
        }
    }

    public int GetTotalTaskCount()
    {
        return 5;
    }
}

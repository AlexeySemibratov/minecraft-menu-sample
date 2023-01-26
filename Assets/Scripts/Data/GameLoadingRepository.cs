using System;
using System.Threading.Tasks;

public class GameLoadingRepository
{
    private Random _random = new Random();

    private int _taskCount;

    public GameLoadingRepository()
    {
        _taskCount = _random.Next(4, 7);
    }

    public async Task LoadGame(Action<int> taskProgressCallback)
    {
        // Emulate hard loading
        for (int i = 1; i < GetTotalTaskCount(); i++)
        {
            await Task.Delay(_random.Next(750, 1500));
            taskProgressCallback(i);
        }
    }

    public int GetTotalTaskCount()
    {
        return _taskCount;
    }
}

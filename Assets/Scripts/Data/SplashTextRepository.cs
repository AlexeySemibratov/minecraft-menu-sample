using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

public class SplashTextRepository
{
    private const string FilePath = "Assets/Resources/Text/splashes.txt";

    private string[] _splashesCache = { };

    public IEnumerable<string> GetSplashes()
    {
        return _splashesCache;
    }

    public async Task LoadSplashes()
    {
        _splashesCache = await Task.FromResult(LoadSplashesFromFile());
    }

    private string[] LoadSplashesFromFile()
    {
        var lines = File.ReadAllLines(FilePath);
        return lines;
    }
}

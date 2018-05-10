using UnityEngine.SceneManagement;

public class GameManager
{
    private string _initialScene;
    private string _gameOverScene;
    private string _victoryScene;
    private string[] _levelScenes;
    private int _currentLevel = 0;

    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            return _instance;
        }
    }

    public static void InitGameManager(GameManagerInitRequest request)
    {
        var manager = new GameManager(request);
        _instance = manager;
    }

    private GameManager(GameManagerInitRequest request)
    {
        _initialScene = request.InitialScene;
        _gameOverScene = request.GameOverScene;
        _victoryScene = request.VictoryScene;
        _levelScenes = request.LevelScenes;
    }

    public void LoadInitialScene()
    {
        _currentLevel = -1;
        SceneManager.LoadScene(_initialScene);
    }

    public void Retry()
    {
        _currentLevel = 0;
        SceneManager.LoadScene(_initialScene);
    }

    public void LoadNextLevel()
    {
        _currentLevel++;
        if (_currentLevel >= _levelScenes.Length)
        {
            SceneManager.LoadScene(_victoryScene);
        }
        else
        {
            SceneManager.LoadScene(_levelScenes[_currentLevel]);
        }
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene(_gameOverScene);
    }
}

public class GameManagerInitRequest
{
    public string InitialScene { get; set; }
    public string GameOverScene { get; set; }
    public string VictoryScene { get; set; }
    public string[] LevelScenes { get; set; }
}

GameManager.InitGameManager(request);
GameManager.Instance.LoadNextLevel()
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class JailbreakSceneManager : MonoBehaviour {

    [SerializeField]
    private bool _autoLoad;

    [SerializeField]
    private string _initialScene;
    [SerializeField]
    private string _gameOverScene;
    [SerializeField]
    private string _victoryScene;
    [SerializeField]
    private string[] _levelScenes;

    private int _currentLevel = -1;

    private static JailbreakSceneManager _instance;
    public static JailbreakSceneManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("SceneManager not in scene");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        if (_autoLoad)
        {
            Invoke("LoadScene", 5);
        }
        else
        {
            LoadInitialScene();
        }
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

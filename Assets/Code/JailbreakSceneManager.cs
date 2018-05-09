using UnityEngine;
using UnityEngine.SceneManagement;

public class JailbreakSceneManager : MonoBehaviour {


    [SerializeField]
    private bool _autoLoad;

    [SerializeField]
    private string _initialScene;

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
    }

    public void LoadScene(string scene)
    {
        Loading.NextScene = scene;
        SceneManager.LoadScene("Loading");
    }

    private void LoadScene()
    {
        Loading.NextScene = _initialScene;
        SceneManager.LoadScene("Loading");
    }
}

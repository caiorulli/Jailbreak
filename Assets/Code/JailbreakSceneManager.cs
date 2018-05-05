using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

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
        SceneManager.LoadScene(scene);
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(_initialScene);
    }
}

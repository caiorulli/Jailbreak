using Assets.Code;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JailbreakSceneManager : MonoBehaviour {

    [SerializeField]
    private bool _autoLoad;

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
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "StartScreen" || scene.name == "Victory" || scene.name == "Game Over")
        {
            Cursor.visible = true;
        } else
        {
            Cursor.visible = false;
        }
        if (_autoLoad)
        {
            Invoke("LoadScene", 5);
        }
    }

    public void LoadScene(string scene)
    {   
        if (scene == "StartScreen")
        {
            GameState.Instance.HandleStageCompletion(scene);
        }
        SceneManager.LoadScene(scene);
    }
    
    private void LoadScene()
    {
        SceneManager.LoadScene(GameState.TUTORIAL);
    }

    public void LoadLoading()
    {
        SceneManager.LoadScene(GameState.LOADING);
    }
}

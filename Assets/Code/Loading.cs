using Assets.Code;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour {
    private AsyncOperation _operation;

    [SerializeField]
    private float _percent;
    
    [SerializeField]
    private GUIText text;

	// Use this for initialization
	void Start () {
        _percent = 0;
        _operation = SceneManager.LoadSceneAsync(GameState.Instance.GetNextScene());
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Loading: " + _operation.progress * 100 + "%");
	}
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour {
    private AsyncOperation _operation;

    [SerializeField]
    private string _nextScene;

    [SerializeField]
    private float _percent;
    
    [SerializeField]
    private GUIText text;

	// Use this for initialization
	void Start () {
        _percent = 0;
        _operation = SceneManager.LoadSceneAsync(_nextScene);
        _operation.allowSceneActivation = false;
	}
	
	// Update is called once per frame
	void Update () {
        _percent = Mathf.MoveTowards(_percent, (_operation.progress * 100) + 10, Time.deltaTime * 10);
        // text.text = _percent.ToString("000.00") + "%";
        Debug.Log(_percent);
        if (_percent == 100)
        {
            _operation.allowSceneActivation = true;
        }
	}
}

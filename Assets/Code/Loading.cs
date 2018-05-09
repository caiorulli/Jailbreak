using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour {
    public static string NextScene { get; set; }
    private AsyncOperation _operation;

    [SerializeField]
    private float _percent;

    [SerializeField]
    private TextMesh text;

	// Use this for initialization
	void Start () {
        _operation = SceneManager.LoadSceneAsync(NextScene);
        _operation.allowSceneActivation = false;
	}
	
	// Update is called once per frame
	void Update () {
        _percent = Mathf.MoveTowards(_percent, (_operation.progress * 100) + 10, Time.deltaTime * 2);
        text.text = _percent.ToString("000.00") + "%";
        if (_percent == 100)
        {
            _operation.allowSceneActivation = true;
        }
	}
}

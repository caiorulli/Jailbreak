using UnityEngine;

public class LevelComplete : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            JailbreakSceneManager.Instance.LoadScene("Victory");
        }
    }
}
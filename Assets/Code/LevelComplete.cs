using UnityEngine;
using UnityEngine.AI;
using System.Collections;
public class LevelComplete : MonoBehaviour {
    JailbreakSceneManager _JailbreakSceneManager = new JailbreakSceneManager();

    // JailbreakSceneManager jb = gameObject.AddComponent(typeof (JailbreakSceneManager)) as JailbreakSceneManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            _JailbreakSceneManager.LoadScene("Victory");
        }
    }
}
using UnityEngine;
using UnityEngine.AI;
using System.Collections;
public class LevelComplete : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            JailbreakSceneManager.Instance.LoadNextLevel();
        }
    }
}
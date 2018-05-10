using UnityEngine;
using System.Collections;

public class PlayerDetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            JailbreakSceneManager.Instance.LoadGameOver();
            // UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}

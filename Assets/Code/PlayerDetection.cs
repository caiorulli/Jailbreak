using UnityEngine;
using System.Collections;

public class PlayerDetection : MonoBehaviour
{   
    JailbreakSceneManager _JailbreakSceneManager = new JailbreakSceneManager();
    // public JailbreakSceneManager _JailbreakSceneManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            _JailbreakSceneManager.LoadScene("Game Over");
            // UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}

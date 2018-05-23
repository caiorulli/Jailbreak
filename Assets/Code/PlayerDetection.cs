﻿using UnityEngine;

public class PlayerDetection : MonoBehaviour
{   
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            JailbreakSceneManager.Instance.LoadScene("Game Over");
        }
    }
}

using Assets.Code;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{   
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            RaycastHit hit;
            Physics.Raycast(transform.position, other.gameObject.transform.position - transform.position, out hit, 15);
            if (hit.collider.gameObject.Equals(other.gameObject)) {
                JailbreakSceneManager.Instance.LoadScene(GameState.GAME_OVER);
            }
        }
    }
}

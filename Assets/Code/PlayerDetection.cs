using Assets.Code;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    private bool _playerDetected = false;
    private Collider _player;

    void Update()
    {
        if (_playerDetected && _player != null)
        {
            RaycastHit hit;
            Physics.Raycast(transform.position, _player.gameObject.transform.position - transform.position, out hit, 15);
            if (hit.collider.gameObject.Equals(_player.gameObject))
            {
                JailbreakSceneManager.Instance.LoadScene(GameState.GAME_OVER);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            _playerDetected = true;
            _player = other;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            _playerDetected = false;
            _player = null;
        }
    }
}

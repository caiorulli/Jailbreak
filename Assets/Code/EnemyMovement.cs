using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {
    [SerializeField]
    private GameObject _route;

    private NavMeshAgent _agent;
    private Transform[] _waypoints;
    private int _currentWaypoint;
    private int _previousWaypoint;

    private int _auxValue;

	void Start () {
        _agent = GetComponent<NavMeshAgent>();
        _waypoints = _route.GetComponentsInChildren<Transform>();
        _currentWaypoint = 1;
        _previousWaypoint = 0;
        // _currentWaypoint = Random.Range(1, _waypoints.Length) - 1;
        _agent.SetDestination(GetNextWaypointPosition());
	}
	
	void Update () {
        Vector3 distanceToNextWaypoint = _waypoints[_currentWaypoint].position - transform.position;
        if (distanceToNextWaypoint.magnitude < 2.5)
        {
            SwitchToNextWaypoint();
            _agent.SetDestination(GetNextWaypointPosition());
        }
	}

    private Vector3 GetNextWaypointPosition()
    {
        return _waypoints[_currentWaypoint].position;
    }

    private void SwitchToNextWaypoint()
    {
        _auxValue = _previousWaypoint;
        _previousWaypoint = _currentWaypoint;

        if (_currentWaypoint == 1) {
            if (_auxValue == 0 || _auxValue == 5) {
                _currentWaypoint = 2;
            }
            else if (_auxValue == 2) {
                _currentWaypoint = 4;
            }
            else if (_auxValue == 4) {
                _currentWaypoint = 5;
            }
        }

        else if (_currentWaypoint == 2){
            if (_auxValue == 1) {
                _currentWaypoint = 3;
            }
            else if (_auxValue == 3) {
                _currentWaypoint = 1;
            }
        }

        else if (_auxValue == 3) {
            _currentWaypoint = 2;
        }

        else if (_auxValue == 4 || _auxValue == 5) {
            _currentWaypoint = 1;
        }

        // else {
        //  _currentWaypoint = (_currentWaypoint + 1) % _waypoints.Length;
        // }
    }
}
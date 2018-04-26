using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {
    [SerializeField]
    private GameObject _route;

    private NavMeshAgent _agent;
    private Transform[] _waypoints;
    private int _currentWaypoint;

	void Start () {
        _agent = GetComponent<NavMeshAgent>();
        _waypoints = _route.GetComponentsInChildren<Transform>();

        _currentWaypoint = Random.Range(1, _waypoints.Length) - 1;
        _agent.SetDestination(GetNextWaypointPosition());
	}
	
	void Update () {
        Vector3 distanceToNextWaypoint = _waypoints[_currentWaypoint].position - transform.position;
        if (distanceToNextWaypoint.magnitude < 3)
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
        _currentWaypoint = (_currentWaypoint + 1) % _waypoints.Length;
    }
}

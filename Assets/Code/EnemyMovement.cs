using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {
    [SerializeField]
    private GameObject[] _waypoints;

    private NavMeshAgent _agent;
    private int _currentWaypoint;
    private int _previousWaypoint;

    private int _auxValue;

	void Start () {
        _agent = GetComponent<NavMeshAgent>();
        _currentWaypoint = 0;
        _agent.SetDestination(GetNextWaypointPosition());
	}
	
	void Update () {
        Vector3 distanceToNextWaypoint = _waypoints[_currentWaypoint].transform.position - transform.position;
        if (distanceToNextWaypoint.magnitude < 3.5)
        {
            SwitchToNextWaypoint();
            _agent.SetDestination(GetNextWaypointPosition());
        }
	}

    private Vector3 GetNextWaypointPosition()
    {
        return _waypoints[_currentWaypoint].transform.position;
    }

    private void SwitchToNextWaypoint()
    {
        _currentWaypoint = (_currentWaypoint + 1) % _waypoints.Length;
        Debug.Log("Waypoint: " + _currentWaypoint);
    }
}
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
        _waypoints = GetComponentsInChildren<Transform>();

        _currentWaypoint = Random.Range(1, _waypoints.Length);
        _agent.SetDestination(_waypoints[_currentWaypoint].position);
	}
	
	void Update () {
        Vector3 distanceToNextWaypoint = _waypoints[_currentWaypoint].position - transform.position;
        if (distanceToNextWaypoint.magnitude < 3)
        {
            _currentWaypoint = (_currentWaypoint + 1) % _waypoints.Length;
            _agent.SetDestination(_waypoints[_currentWaypoint].position);
        }
	}
}

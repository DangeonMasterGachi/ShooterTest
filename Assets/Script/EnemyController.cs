using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(EnemyVision))]
public class EnemyController : MonoBehaviour
{
    public Transform[] PatrolPosition;
    private NavMeshAgent agent;
    public GameObject _player;

    [SerializeField] private int enemyHeals = 100;
    private int pointIndex;
    private EnemyVision enemyVision;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        enemyVision = GetComponent<EnemyVision>();
    }
    private void Start()
    {
        enemyVision.PlayerInVision += OnPlayerInVision;
        enemyVision.PlayerLost += SetPatrolPoint;
    }


    void Update()
    {
       if(!agent.pathPending && agent.remainingDistance <= .5f)
        {
            SetPatrolPoint();
        }
       if(enemyHeals == 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullet"))
        {
            agent.SetDestination(_player.transform.position);
            enemyHeals -= 10;
        }
    }

    void SetPatrolPoint()
    {
        var dest = PatrolPosition[pointIndex % PatrolPosition.Length].position;

        agent.destination = dest;

        pointIndex++;
    }


    void OnPlayerInVision(Vector3 pos)
    {
        agent.destination = pos;
    }
}

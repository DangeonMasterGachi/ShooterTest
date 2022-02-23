using System;
using UnityEngine;

[RequireComponent(typeof(EnemyController))]

public class EnemyVision : MonoBehaviour
{
    public Action<Vector3> PlayerInVision;
    public Action PlayerLost;
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerInVision?.Invoke(other.transform.position);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        PlayerLost?.Invoke();
    }
}

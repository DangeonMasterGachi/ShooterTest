using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurelController : MonoBehaviour
{
    public Transform target;
    public GameObject Ammo;
    public int _turrelHP = 200;
    void Start()
    {
        
    }

    
    void Update()
    {
       if(_turrelHP == 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
         Vector3 relPos = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relPos);
        transform.rotation = rotation;
        Instantiate(Ammo, transform.position, transform.rotation);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullet"))
        {
            _turrelHP -= 10;

        }
    }
}

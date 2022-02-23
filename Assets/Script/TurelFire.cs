using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurelFire : MonoBehaviour
{
    
    public float speedAmmo = 3f;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.forward * speedAmmo * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            
        }
    }


}

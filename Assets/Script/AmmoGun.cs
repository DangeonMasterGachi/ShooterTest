using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoGun : MonoBehaviour
{
    public float speedAmmo = 10f;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.forward * speedAmmo * Time.deltaTime);
       
    }
}

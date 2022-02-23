using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject ammo;
    void Start()
    {
        GetComponent<PlayerController>();
        
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        {
            PlayerController player;
            Instantiate(ammo, transform.position, transform.rotation);
        }
    }
}

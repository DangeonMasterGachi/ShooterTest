using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    List<KeyContrpller> keyList;

    private void Start()
    {
        keyList = new List<KeyContrpller>();
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Key"))
        {
            keyList.Add(GetComponent<KeyContrpller>());
            Destroy(gameObject);
        }
       
       
    }

}

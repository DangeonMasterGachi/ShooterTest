using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
   public Rigidbody player;
    public Rigidbody enemy;
    float boom = 3300f;
    void Start()
    {
       
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            player.AddForce(Vector3.up * boom * Time.deltaTime);

            Debug.Log("Ты взорвался");
        }
    }



}

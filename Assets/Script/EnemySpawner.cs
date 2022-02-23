using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    private int i;
    void Start()
    {
        StartCoroutine("CoroutineSample");
    }

    private void Update()
    {
        
        
    }

    IEnumerator CoroutineSample()
    {
            while(true)
        {
            yield return new WaitForSeconds(10f);
            Instantiate(Enemy, transform.position, transform.rotation);
        }
            

       

        
    }
    
   
}

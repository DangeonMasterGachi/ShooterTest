using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranatBoomController : MonoBehaviour
{
    public GameObject Bomb;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            
           var bm = Instantiate(Bomb, transform.position, Quaternion.identity);
            bm.AddComponent<MineBoom>();
            

        }
    }
}
public class MineBoom: MonoBehaviour
{
    bool _inRange;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy") && _inRange == true)
        {
            Debug.Log("BOOM!");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Player exit position!");
            _inRange = true;
        }
    }
}
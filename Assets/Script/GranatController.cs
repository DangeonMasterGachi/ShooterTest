using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranatController : MonoBehaviour
{   public float speedBomb = 15f;
    public GameObject _granat;
    public Rigidbody _rigBomb;
    void Start()
    {
        
       
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            GranatExploing();
        }
    }
    void GranatExploing()
    {
        GameObject _granad = Instantiate(_granat, transform.position, transform.rotation);
        Rigidbody _rbGranat = _granad.GetComponent<Rigidbody>();
        _rbGranat.AddForce(transform.forward * speedBomb, ForceMode.VelocityChange);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class FistsEnemyDamage : MonoBehaviour
{
    public int _damage = 10;
    public float _damageForce = 10000f;
    public Rigidbody _playerRB;
    public Animation _fightAnimator;

    private void Start()
    {
    
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            PlayerController _plHealth = other.GetComponent<PlayerController>();
            _plHealth.TakeDamage(_damage);
            _playerRB.AddForce(Vector3.forward * _damageForce);
            _fightAnimator.Play();
            
        }
    }

   

}

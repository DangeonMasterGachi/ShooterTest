using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject _panelGO;
    public Rigidbody player;
    public Text _hpText;
    public Vector3 tir;
    public GameObject Camera;
    public Text _speedText;
    public int _speedStat = 100;

    public int _health;
    public int _maxHealth;

    public float speed = 5f;
    public float speedJump = 15f;
    void Start()
    {
         player = GetComponent<Rigidbody>();
    }

    public void TakeDamage(int _damage)
    {
        _health -= _damage;
        if(_health == 0)
        {
            Time.timeScale = 0;
            _panelGO.SetActive(true);
        }
    }

    public void SetHealth(int _bonusHealth)
    {
        _health += _bonusHealth;
        if(_health >= _bonusHealth)
        {
            _health = _bonusHealth;
        }
    }

    
    void Update()
    {
        _hpText.text = "Здоровья: " + _health;

        tir.x = Input.GetAxis("Horizontal");
        tir.z = Input.GetAxis("Vertical");

        var r = tir * speed * Time.deltaTime;
        transform.Translate(tir * speed * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            player.AddForce(Vector3.up * speedJump, ForceMode.Impulse);
        }

        

       
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            
            speed = 8f;
           
        }
       
    }

    public void AddKey(KeyType key)
    {

    }

}

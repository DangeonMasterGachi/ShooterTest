using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObjectView : MonoBehaviour
{
    [SerializeField] KeyType KeyType;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<PlayerKeyController>().AddObject(new PickableObjectData(KeyType));
            Debug.Log("Ты подобрал ключ!");
        }
    }


}

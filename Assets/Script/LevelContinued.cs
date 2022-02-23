using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelContinued : MonoBehaviour
{
    public GameObject _panelLevel;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Time.timeScale = 0;
            _panelLevel.SetActive(true);
        }
    }

}

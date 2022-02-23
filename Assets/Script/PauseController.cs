using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public GameObject _Panel;

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            _Panel.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.Confined;
        }
        else
        {
        
        }
    }
    public void OnClickPause()
    {
        Time.timeScale = 1;
        _Panel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}

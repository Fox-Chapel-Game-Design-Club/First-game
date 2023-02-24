using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pauseMenuUI;
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        PauseMenu.IsPaused = false;
        Debug.Log("resume clicked");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

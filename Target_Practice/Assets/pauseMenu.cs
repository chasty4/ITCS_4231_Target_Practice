using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public static bool paused = false;
    public GameObject pMenu;
    public GameObject gameUI;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!paused)
            {
                Pause();
            } else
            {
                Resume();
            }
        }

        //Debug.Log("Paused: " + paused);
        
    }


    public void Pause()
    {
        gameUI.SetActive(false);
        Time.timeScale = 0f;
        pMenu.SetActive(true);
        paused = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Resume()
    {
        gameUI.SetActive(true);
        Time.timeScale = 1f;
        pMenu.SetActive(false);
        paused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Quit()
    {
        Application.Quit();
    }
}

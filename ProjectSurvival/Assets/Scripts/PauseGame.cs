using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject PauseMenuCanvasObject;

    bool GameIsPaused = false;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       if (GameIsPaused && Input.GetKeyDown(KeyCode.Escape))
        {
            ResumeGame();
        } 
       else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        Time.timeScale = 0;
        PauseMenuCanvasObject.SetActive(true);
        GameIsPaused = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        GameIsPaused = false;
        PauseMenuCanvasObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumePauseScript : MonoBehaviour
{
    
    public bool isPaused = false;


    public void PauseGame()
    {
        
        if (isPaused == true)
        {
            Time.timeScale = 1;
            isPaused = false;
        }

        else
        { 
            Time.timeScale = 0;
            isPaused = true;

        }
    }

}

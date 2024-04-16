using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteMenuScript : MonoBehaviour
{

    void Start(){
        Time.timeScale = 0f;
    }


    public void Restart()
    {
        
        SceneManager.LoadScene("Map1");
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        
        SceneManager.LoadScene("HomeScreen");
        Time.timeScale = 1f;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchScene : MonoBehaviour
{
    // private Button startButton;
    [SerializeField] private String newSceneName;
    
    // Start is called before the first frame update
    void Start()
    {
        // startButton = GameObject.Find("StartButton").GetComponent<Button>();
        // startButton.onClick.AddListener(StartGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchScenes()
    {
        SceneManager.LoadScene(newSceneName);
        
    }

}

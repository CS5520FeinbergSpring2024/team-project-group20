using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmDialog : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI levelNameText;
    [SerializeField] private TextMeshProUGUI bestTimeText;
    [SerializeField] private RawImage previewImage;
    [SerializeField] private Texture[] levelPreviewImgs;
    [SerializeField] private SwitchScene playButton;

    private Canvas window;
    
    // Start is called before the first frame update
    void Start()
    {
        window = GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetArgs(String levelName, String bestTime, int levelNumber)
    {
        levelNameText.SetText(levelName);
        bestTimeText.SetText(bestTime);
        previewImage.texture = levelPreviewImgs[levelNumber - 1];
        playButton.SetNewSceneName("Map" + levelNumber);

    }

    public void Show()
    {
        window.enabled = true;
    }

    public void Cancel()
    {
        window.enabled = false;
    }

}

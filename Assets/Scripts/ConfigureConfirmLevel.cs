using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ConfigureConfirmLevel : MonoBehaviour
{
    [SerializeField] private ConfirmDialog confirmDialog;
    [SerializeField] private TextMeshProUGUI levelNameText;
    [SerializeField] private TextMeshProUGUI bestTimeText;
    [SerializeField] private int levelNumber; // 1 indexed
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenConfirmDialog()
    {
        confirmDialog.SetArgs(levelNameText.text, bestTimeText.text, levelNumber);
        confirmDialog.Show();
    }
    
}

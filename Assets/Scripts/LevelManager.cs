using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject levelCompleteMenu;
    [SerializeField] GameObject player;
    [SerializeField] GameObject start;
    [SerializeField] GameObject timerText;
    
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restartLevel()
    {
        StartCoroutine(goToStart());
        EventManager.OnTimerUpdate(60.0f);
        EventManager.OnTimerStart();
    }

    public void endLevel() {
        levelCompleteMenu.SetActive(true);
        EventManager.OnTimerStop();
    }

    IEnumerator goToStart()
    {
        
        player.GetComponent<MeshRenderer>().enabled = false;
        yield return new WaitForSecondsRealtime(0.1f);
        player.transform.position = new Vector3(start.transform.position.x, start.transform.position.y, player.transform.position.z);
        player.GetComponent<MeshRenderer>().enabled = true;
        timerText.SetActive(true);
        EventManager.OnTimerUpdate(60.0f);
        EventManager.OnTimerStart();
    }
}

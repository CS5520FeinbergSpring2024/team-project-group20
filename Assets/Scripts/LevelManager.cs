using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject levelCompleteMenu;
    [SerializeField] GameObject player;
    [SerializeField] GameObject start;

    
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restartLevel()
    {
        StartCoroutine(goToStart());
    }

    public void endLevel() {
        levelCompleteMenu.SetActive(true);
        
    }

    IEnumerator goToStart()
    {
        player.GetComponent<MeshRenderer>().enabled = false;
        yield return new WaitForSecondsRealtime(0.1f);
        player.transform.position = new Vector3(start.transform.position.x, start.transform.position.y, player.transform.position.z);
        player.GetComponent<MeshRenderer>().enabled = true;
    }
}

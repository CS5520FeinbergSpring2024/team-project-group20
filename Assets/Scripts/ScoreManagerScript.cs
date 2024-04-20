using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManagerScript : MonoBehaviour
{
    void Awake() {
        DontDestroyOnLoad(this.gameObject);
    }

    public static void LevelCompleted(int levelID, string score)
    {
        PlayerPrefs.SetString("LevelCompleted_" + levelID, score);
        PlayerPrefs.Save();
    }

    public static bool IsLevelCompleted(int levelID)
    {
        return PlayerPrefs.GetString("LevelCompleted_" + levelID, "") != "";
    }

    public static void ResetLevels()
    {
        for(int i = 0; i < 10; i++)
        {
            PlayerPrefs.DeleteKey("LevelCompleted_" + i);
        }
        PlayerPrefs.Save();
    }

}

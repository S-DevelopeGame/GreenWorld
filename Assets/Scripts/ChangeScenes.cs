using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    [Tooltip("names of the scenes")] [SerializeField] private string[] sceneName;
    [SerializeField] private TakeObject takeObject;
    private const int GAMEOVER = 0, NEXTGAME = 1, STARTGAME = 2;
    private void Update()
    {
        if (TimedSpawnerRandom.numberOfRespawn > 40)
        {
            SceneManager.LoadScene(sceneName[GAMEOVER]); // the objects on the floor more than 40 -> gameover
            TimedSpawnerRandom.numberOfRespawn = 0;
        }
        else if(takeObject.getScore() >= 100) //the score more than 100 -> next level
        {
            SceneManager.LoadScene(sceneName[NEXTGAME]);
            TimedSpawnerRandom.numberOfRespawn = 0;
        }
    }



}

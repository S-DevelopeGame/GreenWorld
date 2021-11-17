using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainButton : MonoBehaviour
{
    [SerializeField] private string sceneName;
    public void restart()
    {
        SceneManager.LoadScene(sceneName);


    }
}

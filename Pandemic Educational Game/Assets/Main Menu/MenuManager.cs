using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    int sceneToLoad=1;
    public void PlayButton()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}

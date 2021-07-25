using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    int sceneToLoad;
    public void PlayButton()
    {
        sceneToLoad = Random.Range(1, 5);
        SceneManager.LoadScene(sceneToLoad);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}

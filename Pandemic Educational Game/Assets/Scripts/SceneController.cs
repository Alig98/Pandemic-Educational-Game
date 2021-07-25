﻿using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public static SceneController Instance { get; set; }
    int sceneToLoad=1;
    int tempScene;
    public Slider timer;
    public float time;
    public GameObject frame;

    private void Awake()
    {
        Instance = this;
        sceneToLoad = SceneManager.GetActiveScene().buildIndex;
        timer.maxValue = time;
       
    }
    void Update()
    {
        timer.value += Time.deltaTime;
        if (timer.value == timer.maxValue)
        {
            frame.SetActive(true);
            
        }
        if (frame.activeSelf)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(0);
            }
        }
    }

   
    public void AnotherLevel()
    {
        tempScene = Random.Range(1, 5);

        while (tempScene == sceneToLoad)
        {
            tempScene = Random.Range(1, 5);
        }
        sceneToLoad = tempScene;
        SceneManager.LoadScene(sceneToLoad);
    }

}
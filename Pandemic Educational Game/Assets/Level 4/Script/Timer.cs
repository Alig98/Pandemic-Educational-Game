using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider timer;
    public GameObject frame;
    void Start()
    {
        timer.maxValue = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        timer.value += Time.deltaTime;
        if(timer.value == timer.maxValue)
        {
            frame.SetActive(true);
        }
    }
}

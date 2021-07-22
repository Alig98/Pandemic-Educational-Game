using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider timer;
    public float time;
    public GameObject frame;
    void Start()
    {
        timer.maxValue = time;
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

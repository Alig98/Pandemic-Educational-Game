using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider timer;
    void Start()
    {
        timer.maxValue = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        timer.value += Time.deltaTime;
    }
}

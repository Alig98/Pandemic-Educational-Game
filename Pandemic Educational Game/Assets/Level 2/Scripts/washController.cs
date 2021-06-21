using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class washController : MonoBehaviour
{
    float t = 0;
    private Animator myAnim;
    private Text timer;
    bool started = false;
    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<Text>();
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            myAnim.SetBool("isWashing", true);
            started = true;
        }
        if (started)
        {
            t += Time.deltaTime;
            timer.text = ((int) t).ToString();
            if (t >= 20)
            {
                Debug.Log("Level Completed");
                started = false;
                
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            myAnim.SetBool("isWashing", false);
            started = false;
            t = 0;
            timer.text = ((int)t).ToString();
        }
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class washController : MonoBehaviour
{
    private Animator myAnim;
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            myAnim.SetBool("isWashing", true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            myAnim.SetBool("isWashing", false);
        }
    }
}

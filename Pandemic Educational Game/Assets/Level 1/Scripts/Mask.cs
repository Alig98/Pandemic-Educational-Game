using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mask : MonoBehaviour
{
    public float RotationSpeed = 5;

    // Update is called once per frame
    void Update()
    {


    }
    private void OnMouseDrag()
    {
        transform.Rotate((Input.GetAxis("Mouse Y") * RotationSpeed), 0, 0, Space.World);
    }
}

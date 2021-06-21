using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mask : MonoBehaviour
{
    private float RotationSpeed = 5;

    public void setRotationSpeed(float newRtSpeed)
    {
        RotationSpeed = newRtSpeed;
    }

    private void OnMouseDrag()
    {
        transform.Rotate((Input.GetAxis("Mouse Y") * RotationSpeed), 0, 0, Space.World);
    }
}

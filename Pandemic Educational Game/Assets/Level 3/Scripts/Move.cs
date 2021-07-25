using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float speed;
    private void Start()
    {
        speed = Random.Range(5, 12);
    }
    private void Update()
    {
        transform.position += transform.forward * speed*Time.deltaTime;
    }
}

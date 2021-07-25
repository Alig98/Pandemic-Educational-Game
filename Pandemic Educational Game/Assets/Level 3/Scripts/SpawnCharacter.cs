using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCharacter : MonoBehaviour
{
    private float xRange=150;
    private float zRange = 18;
    private int characterCount = 20;
    public GameObject[] characters;
    int charIndex = 0;
    Vector3 position;
    void Start()
    {
        for(int i = 0; i < characterCount; i++)
        {
            position= new Vector3(Random.Range(-100f, xRange), 0, Random.Range(-zRange, zRange));
            charIndex = Random.Range(0, characters.Length - 1);
            Instantiate(characters[charIndex],position , Quaternion.Euler(0,-90,0),this.transform);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    
}

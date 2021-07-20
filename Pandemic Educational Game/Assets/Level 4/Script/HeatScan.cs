using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HeatScan : MonoBehaviour
{
    float heat;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        heat = Random.Range((float)36,(float)40);
        other.gameObject.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = heat.ToString("0.#");
    }
}

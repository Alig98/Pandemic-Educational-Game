using UnityEngine;
using TMPro;


public class HeatScan : MonoBehaviour
{
    float heat;
    bool isOkay=false;
    private GameObject h;
    int headIndex = 1;
    

    void Start()
    {
        h = GameObject.Find("Heads");
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Setting canvas active
        GameObject canvas=other.transform.GetChild(1).gameObject;
        canvas.SetActive(true);
        heat = Random.Range((float)36,(float)40);
        canvas.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = heat.ToString("0.#");
        if (heat < 37.5f)
        {
            isOkay = true;
        }
        else
        {
            isOkay = false;
        }
     
        
    }
    public void TickButton()
    {
        if (!isOkay)
        {
            notWin();
           
        }
        else
        {
            slideHead();
           
        }
    }
    public void CrossButton()
    {
        if (isOkay)
        {
            notWin();
        }
        else
        {
            slideHead();
            
        }
    }
    private void slideHead()
    {
        if (headIndex == h.transform.childCount)
        {
            SceneController.Instance.AnotherLevel();
        }
        else
        {
            Vector3 v3 = h.transform.position - Vector3.right * 3;
            h.transform.SetPositionAndRotation(v3, Quaternion.identity);
        }
        
       

    }
    private void notWin()
    {
        SceneController.Instance.frame.SetActive(true);
        

    }

}

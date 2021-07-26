using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class washController : MonoBehaviour
{
    float t = 0;
    private Animator myAnim;
    private TextMeshProUGUI timer;
    bool started = false;
    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<TextMeshProUGUI>();
        myAnim = GetComponent<Animator>();
    }

    
    void Update()
    {
        //Tıklanınca yıkamaya başlıyor
        if (Input.GetMouseButtonDown(0))
        {
            myAnim.SetBool("isWashing", true);
            started = true;
        }
        if (started)
        {
            t += Time.deltaTime;
            timer.text = ((int) t).ToString();
            //20 saniye yıkayınca bölüm başarıyla geçiliyor
            if (t >= 20)
            {

                SceneController.Instance.AnotherLevel();
                started = false;
                
            }
        }
        //Tıklama bırakılınca yıkamayı bırakıyor
        if (Input.GetMouseButtonUp(0))
        {
            //Zaman ve animason sıfırlanıyor
            myAnim.SetBool("isWashing", false);
            started = false;
            t = 0;
            timer.text = ((int)t).ToString();
        }
    }

    
}

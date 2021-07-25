using UnityEngine.UI;
using UnityEngine;

public class Character : MonoBehaviour
{
    Vector3 mousePos;
    Animator animator;
    Vector3 dragTowards;
    public Image circle;
    public Sprite redCircle;
    public Sprite greenCircle;
    private float time=1f;
    private bool timerStart=false;
    [SerializeField]private float speed=15f;
    private void Start()
    {
        animator = GetComponent<Animator>();
        circle.sprite = greenCircle;
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            animator.SetBool("isWalking", true);
            mousePos = Input.mousePosition;
            mousePos.z = 10;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            dragTowards = (transform.position - mousePos);
            transform.forward = new Vector3(dragTowards.x, 0, -dragTowards.z * 2f);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("isWalking", false);
        }
        if (timerStart)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                SceneController.Instance.frame.SetActive(true);
            }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
       
        timerStart = true;
        Debug.Log(time);
        circle.sprite = redCircle;
        
       
    }
    private void OnTriggerExit(Collider other)
    {
        timerStart = false;
        circle.sprite = greenCircle;
        time = 1f;
    }
}

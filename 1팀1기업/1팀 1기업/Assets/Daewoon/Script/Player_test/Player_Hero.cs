using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player_Hero : MonoBehaviour
{
    [SerializeField] float HeroPower;

    Rigidbody2D rb;
    float startTime;
    private bool ButtonDown;
    public float PlayerHp = 2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
        startTime = Time.time + 3f;
    }

    void Update()
    {

        if (Time.time >= startTime)
            rb.isKinematic = false;

        if(ButtonDown)
        {
            rb.AddForce(new Vector2(0f, HeroPower), ForceMode2D.Force);
        }
        
    }

    public void PointerDown()
    {
        ButtonDown = true;
    }

    public void PointerUp()
    {
        ButtonDown = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "border")
        {
            PlayerHp--;
            Debug.Log("체력 1감소");

            if(PlayerHp == 0)
            {
                Debug.Log("게임 오버");
            }



        }
    }
}

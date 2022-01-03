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
    public float PlayerHp = 2f;
    public GameObject Hp_01;
    public GameObject Hp_02;

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

        if (ButtonDown)
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
            if(PlayerHp == 1f)
            {
                Hp_01.SetActive(false);
            }
            if(PlayerHp == 0f)
            {
                Hp_02.SetActive(false);
            }



            if (Hp_02.activeSelf == false)
            {
                Debug.Log("���� ����");
            }
        }
    }
}
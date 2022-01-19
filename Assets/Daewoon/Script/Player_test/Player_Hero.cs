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
    public bool isinvincibility = false;
    public float cooltime = 0;
    public bool booste = false;
    public int Score = 0;


    PolygonCollider2D polygon;
    SpriteRenderer spriterenderer;
    
    
    

    void Start()
    {
        polygon = GetComponent<PolygonCollider2D>();
        spriterenderer = GetComponent<SpriteRenderer>();
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
            rb.AddForce(new Vector2(0,1 * HeroPower * Time.deltaTime) ,ForceMode2D.Force);
            
        }
        if (Input.GetKey(KeyCode.LeftShift) && cooltime <= 0)
        {
            booste = true;
            cooltime = 3;
        }
        if (booste)
        {
            cooltime -= Time.deltaTime;
            if (cooltime <= 0)
            {
                booste = false;
            }
        }
                if (PlayerHp == 1f)
                {
                    Hp_01.SetActive(false);
                }
                if (PlayerHp == 0f)
                {
                    Hp_02.SetActive(false);
                    Debug.Log("게임 오버");
                    Time.timeScale = 0f;
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
            if (isinvincibility == false)
            {
                PlayerHp--;
            }

            if (other.transform.tag == "floor")
            {
                Debug.Log("게임오버");
                Time.timeScale = 0f;
            }
            else
            {
                Ondamaged();
            }
        }
        if(other.transform.tag == "hardborder"&& isinvincibility == false)
        {
            Debug.Log("충돌");
                if(booste == true)
                {
                    Debug.Log("부스터중 충돌");
                    Ondamaged();
                }
                else
                {
                    PlayerHp--;
                    Ondamaged();
                }
        }
        if (other.CompareTag("ScoreBorder"))
        {
            Score += 5000;
        }
    }
    
    public void Ondamaged()
    {
        gameObject.layer = 6;
        spriterenderer.color = new Color(1, 1, 1, 0.4f);
        isinvincibility = true;
        if (gameObject.transform.tag == "border")
            polygon.enabled = false;


        Invoke("OffDamaged", 1.5f);
    }
    void OffDamaged()
    {
        spriterenderer.color = new Color(1, 1, 1, 1);
        isinvincibility = false;
        polygon.enabled = true;
        gameObject.layer = 7;
    }
}

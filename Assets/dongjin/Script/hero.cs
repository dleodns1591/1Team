using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{
    [SerializeField] float HeroPower;

    Rigidbody2D rb;
    float startTime;
    public bool ButtonDown;
    [SerializeField] private float PlayerHp;
    [SerializeField] private GameObject Hp_01;
    [SerializeField] private GameObject Hp_02;
    [SerializeField] private bool isinvincibility = false;
    [SerializeField] private float cooltime;
    [SerializeField] private bool booste=false;
    private SpriteRenderer spriterenderer;
    private float saveposition;
    private float savePower;
    private float savegravity;
    public float test;
    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
        startTime = Time.time + 3f;
        savePower = HeroPower;
        savegravity = rb.gravityScale;
    }

    void Update()
    {
        if (Time.time >= startTime)
        {
            rb.isKinematic = false;
        }
        if (ButtonDown)
        {
            rb.AddForce(new Vector2(0f, HeroPower), ForceMode2D.Force);

        }
        if (Input.GetKey(KeyCode.LeftShift) && cooltime <= 0)
        {
            saveposition = transform.position.y;
            booste = true;
            cooltime = 3;
        }
        booster();
        Hp();
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
        if (other.transform.tag == "hardborder")
        {
            if (isinvincibility == false)
            {
                Ondamaged();
                if (booste == true)
                {
                    
                }
                else
                {
                    PlayerHp--;
                }
            }
        }
    }

    void Ondamaged()
    {
        spriterenderer.color = new Color(1, 1, 1, 0.4f);
        isinvincibility = true;
        Invoke("OffDamaged", 2f);
    }
    void OffDamaged()
    {
        spriterenderer.color = new Color(1, 1, 1, 1);
        isinvincibility = false;
        gameObject.layer = 7;
    }
    void booster()
    {
        if (cooltime >= 0f)
        {
            cooltime -= Time.deltaTime;
            if (cooltime <= 1.5f)
            {
                booste = false;
                rb.gravityScale = savegravity;
                HeroPower = savePower;
            }
            else
            {
                transform.position = new Vector3(this.transform.position.x,saveposition, 0);
                rb.gravityScale = 0;
                HeroPower = 0;
            }
        }
    }
    void Hp()
    {
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
}

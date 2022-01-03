using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Hero1 : MonoBehaviour
{

    public float speed = 1;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {
              
        //Upclick();
    }
    public void Upclick()
    {       
            rb.velocity = Vector2.up * speed;      
    }
}

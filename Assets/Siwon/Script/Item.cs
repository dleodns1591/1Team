using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 moveleft = Vector3.left;
    public float moveRange;
    GameManager GameManager;

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
       
    }
    void Update()
    {
        transform.position += moveleft * moveSpeed * Time.deltaTime;
        if (transform.position.x <= -moveRange)
        {
            Destroy(this.gameObject);
        }
    }

}





using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurdleblock : MonoBehaviour
{
    public  float moveSpeed;
    private Vector3 moveleft = Vector3.left;
    public float moveRange;
    public static BoxCollider2D boxcollider;
    void Update()
    {
        transform.position += moveleft * moveSpeed * Time.deltaTime;
        if (transform.position.x <= -moveRange)
        {
            //Destroy(this.gameObject);
        }
    }
}

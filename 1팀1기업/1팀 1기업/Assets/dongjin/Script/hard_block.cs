using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hard_block : MonoBehaviour
{
    public bool ck = false;
    public GameObject dd;
    private void Update()
    {
        ck = dd.GetComponent<buster>().buste;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "player1" && ck == true)
        {
            Destroy(gameObject);
        }
    }

}

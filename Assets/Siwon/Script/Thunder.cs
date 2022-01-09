using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunder : Item
{
    
    public GameObject ThunderDestroy;
    protected override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player1")
        {
            Debug.Log("플레이어 충돌");
            Destroy(gameObject);
            Instantiate(ThunderDestroy);

        }
        


    }
}

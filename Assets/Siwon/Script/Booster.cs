using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : Item
{
    protected override void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        if(other.tag == "player")
        {

        }
    }
}

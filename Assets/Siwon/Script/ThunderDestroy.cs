using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderDestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "border"|| other.tag == "hardborder"||other.tag == "Item"||other.tag == "ScoreBorder")
        {
            other.gameObject.SetActive(false);
        }
        Destroy(gameObject);
    }

}

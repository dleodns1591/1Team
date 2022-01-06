using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hard_block : MonoBehaviour
{
    public bool ck = false;
    public GameObject dd;
    private void Update()
    {
        dd = GameObject.Find("Hero");
        ck = dd.GetComponent<Player_Hero>().booste;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "player1" && ck == true)
        {
            dd.GetComponent<Player_Hero>().PlayerHp--;
            dd.GetComponent<Player_Hero>().Ondamaged();
        }
    }
}

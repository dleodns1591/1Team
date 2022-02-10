using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorehurdle : MonoBehaviour
{
    Player_Hero player_Hero;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "player1")
        {
            Destroy(gameObject);
            player_Hero.Score += 1000;
        }
    }
}

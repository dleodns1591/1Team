using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorehurdle : MonoBehaviour
{
    GameManager GameManager;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "player1")
        {
            Destroy(gameObject);
            GameManager.Score += 1000;
        }
    }
}

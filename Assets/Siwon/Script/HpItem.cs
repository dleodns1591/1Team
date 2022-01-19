using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpItem : Item
{
    Player_Hero player_Hero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    protected override void OnTriggerEnter2D(Collider2D other)
    {
       if(other.tag == "player")
        {
            Destroy(gameObject);
            if(player_Hero.PlayerHp == 1f)
            {
                player_Hero.PlayerHp = 2f;
            }
            else if(player_Hero.PlayerHp == 2f)
            {
                
            }
        }
    }

}

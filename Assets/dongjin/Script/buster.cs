using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buster : MonoBehaviour
{
    public float cooltime = 0;
    public bool buste = false;
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift)&&cooltime <= 0)
        {
            buste = true;
            cooltime = 3;
        }
        if(buste)
        {
            cooltime -= Time.deltaTime;
            if(cooltime<=0)
            {
                buste = false;
            }    
        }
    }
}

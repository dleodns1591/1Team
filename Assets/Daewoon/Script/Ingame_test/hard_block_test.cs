using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hard_block_test : MonoBehaviour
{
    private void Start()
    {
    }

    private void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "player1")
        {
           //Destroy(gameObject);
           

        }
    }

}

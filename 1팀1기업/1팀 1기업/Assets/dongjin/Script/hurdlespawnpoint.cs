using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurdlespawnpoint : MonoBehaviour
{
    public float spawntime;
    public GameObject hurdle;
    public GameObject hurdle2;
    private float currenttime;
    private float spawnpoint;
    private Vector3 positions;
    private void Start()
    {
        currenttime = spawntime;
    }
    private void Update()
    {
        if(currenttime <= 0)
        {
            spawnpoint = Random.Range(3.5f, 9.5f);
            currenttime = spawntime;
            transform.position = new Vector3(13, spawnpoint, 0);
            if (spawnpoint < 6.5f)
            {
                float dd = Random.Range(1.5f, 3.5f);
                positions = new Vector3(transform.position.x, transform.position.y - dd, 0);

            }
            else
            {
                float dd = Random.Range(9f, 12f);
                positions = new Vector3(transform.position.x, transform.position.y-dd, 0);
            }
            Instantiate(hurdle, transform.position, Quaternion.Euler(0,0,180));
            Instantiate(hurdle2, positions, Quaternion.Euler(0, 0, 180));
            transform.position = new Vector3(13, spawnpoint-14, 0);
            Instantiate(hurdle, transform.position, hurdle.transform.rotation);
            Instantiate(hurdle2, positions, Quaternion.Euler(0, 0, 180));
        }
        else
        {
            currenttime -= Time.deltaTime;
        }
    }
}

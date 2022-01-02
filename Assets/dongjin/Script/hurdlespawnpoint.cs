using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurdlespawnpoint : MonoBehaviour
{
    public float spawntime;
    public GameObject hurdle;
    private float currenttime;
    private float spawnpoint;
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
            Instantiate(hurdle, transform.position, Quaternion.Euler(0,0,180));
            transform.position = new Vector3(13, spawnpoint-14, 0);
            Instantiate(hurdle, transform.position, hurdle.transform.rotation);
        }
        else
        {
            currenttime -= Time.deltaTime;
        }
    }
}

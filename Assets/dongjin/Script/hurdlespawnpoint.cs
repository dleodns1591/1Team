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
    public Itemspawner Itemspawner;
    const int SPAWN_PERCENT = 4;
    void Start()
    {
        currenttime = spawntime;
    }
    void Update()
    {
       
        if (currenttime <= 0)
        {
            currenttime = spawntime;

            spawn();
        }
        else
        {
            currenttime -= Time.deltaTime;
        }

    }
    public void spawn()
    {

        
        spawnpoint = Random.Range(3.5f, 9.5f);
        
        transform.position = new Vector3(13, spawnpoint, 0);
        if (spawnpoint < 6.5f)
        {
            float dd = Random.Range(1.5f, 3.5f);
            positions = new Vector3(transform.position.x, transform.position.y - dd, 0);

        }
        else
        {
            float dd = Random.Range(9.5f, 12f);
            positions = new Vector3(transform.position.x, transform.position.y - dd, 0);
        }
        Instantiate(hurdle, transform.position, Quaternion.Euler(0, 0, 180));
        Instantiate(hurdle2, positions, Quaternion.Euler(0, 0, 180));
        transform.position = new Vector3(13, spawnpoint - 14, 0);
        Instantiate(hurdle, transform.position, hurdle.transform.rotation);
        Instantiate(hurdle2, positions, Quaternion.Euler(0, 0, 180));
        int randSpawnPercent = Random.Range(0, 10);//아이템 확률
        Debug.Log(randSpawnPercent);
        if(randSpawnPercent < SPAWN_PERCENT)
        {
            Debug.Log("아이템 드랍");
            Itemspawner.Spawn(ItemType.Thunder, new Vector3(hurdle.transform.position.x,hurdle.transform.position.y+2,0));//아이템 생성
        }
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hurdlespawnpoint : MonoBehaviour
{

    public float spawntime;
    public GameObject hurdle;
    public GameObject hurdle2;
    public GameObject ScoreHurdle;
    private float currenttime;
    private float spawnpoint;
    private Vector3 positions;
    public Itemspawner Itemspawner;
    
    private GameObject StandardHurdle;


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
        StandardHurdle = Instantiate(hurdle, transform.position, hurdle.transform.rotation);
        Instantiate(hurdle2, positions, Quaternion.Euler(0, 0, 180));
        Scorehurdle(StandardHurdle.transform.position);


        int randSpawnPercent = Random.Range(0, 5);//아이템 확률
       
        switch (randSpawnPercent)
        {
            case 0: 
                Debug.Log("번개 아이템");
                Itemspawner.Spawn(ItemType.Thunder, new Vector3(StandardHurdle.transform.position.x, StandardHurdle.transform.position.y + 6.5f, 0));//아이템 생성
                break;
            case 1:
                Debug.Log("체력 아이템");
                Itemspawner.Spawn(ItemType.HpItem, new Vector3(StandardHurdle.transform.position.x, StandardHurdle.transform.position.y + 6.5f, 0));//아이템 생성
                break;
            default:

                break;
        }

    }
    public void Scorehurdle(Vector3 transform)
    {
        Debug.Log("스코어 보더");
        Instantiate(ScoreHurdle, new Vector3(transform.x, transform.y + 7f, 0), Quaternion.identity);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abstacle : MonoBehaviour
{
    public GameObject upabstacle;
    public GameObject downabstacle;
    
    void Update()
    {
        Fire();
    }
    void Fire()
    {
        float randomYu = Random.Range(2.5f, 0f);

        GameObject background = Instantiate(upabstacle, new Vector2(4, randomYu),Quaternion.identity);
        
    }
}

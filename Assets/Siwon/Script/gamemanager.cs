using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    Text ScoreTx;
    public int Combo;
    public GameObject Instance;
    public int Score = 0;
    void Start()
    {
        ScoreTx.text = "Score:"+ Score;
        Instance = this.gameObject;
    }
}

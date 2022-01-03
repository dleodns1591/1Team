using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Stop_temp : MonoBehaviour
{
    [SerializeField] Image Stop;
    [SerializeField] Transform Start_position;
    [SerializeField] Transform End_position;
    [SerializeField] Transform Close_Btn;
    [SerializeField] Transform Close_Start_Btn;
    [SerializeField] Transform Close_End_Btn;
    [SerializeField] Transform Manu_Btn;
    [SerializeField] Transform Manu_Start_Btn;
    [SerializeField] Transform Manu_End_Btn;

    public GameObject Black;


    public void Start()
    {
        Initialize_01();
    }

    public void Update()
    {

    }

    public void Initialize()
    {
        Stop.transform.DOMove(End_position.position, 0.5f).SetEase(Ease.OutBack);
        Close_Btn.transform.DOMove(Close_End_Btn.position, 0.5f).SetEase(Ease.OutBack);
        Manu_Btn.transform.DOMove(Manu_End_Btn.position, 0.5f).SetEase(Ease.OutBack);
    }

    public void Initialize_01()
    {
        Stop.transform.position = End_position.position;
        Close_Btn.transform.position = Close_End_Btn.position;
        Manu_Btn.transform.position = Manu_End_Btn.position;
    }


    public void DotWeenEase()
    {
        Stop.transform.DOMove(Start_position.position, 0.5f).SetEase(Ease.OutBack);
        Close_Btn.transform.DOMove(Close_Start_Btn.position, 0.5f).SetEase(Ease.OutBack);
        Manu_Btn.transform.DOMove(Manu_Start_Btn.position, 0.5f).SetEase(Ease.OutBack);
    }

    public void Onclick()
    {
        SceneManager.LoadScene("Title");
    }

    public void Stop_delay()
    {
        Time.timeScale = 0f;
        Black.SetActive(true);
    }

    public void Start_delay()
    {
        Time.timeScale = 1f;
        Black.SetActive(false);
    }

    public void Main()
    {
        Time.timeScale = 1f;
    }

    public void Stop_01()
    {
        Invoke("Stop_delay", 0.45f);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Producer_Temp : MonoBehaviour
{
    [SerializeField] Image Producer;
    [SerializeField] Transform Start_position;
    [SerializeField] Transform End_position;
    [SerializeField] Transform Producer_Btn;
    [SerializeField] Transform Producer_Start_Btn;
    [SerializeField] Transform Producer_End_Btn;


    public void Start()
    {
        Initialize_01();
    }

    public void Update()
    {

    }

    public void Initialize()
    {
        Producer.transform.DOMove(End_position.position, 0.5f).SetEase(Ease.OutBack);
        Producer_Btn.transform.DOMove(Producer_End_Btn.position, 0.5f).SetEase(Ease.OutBack);
    }

    public void Initialize_01()
    {
        Producer.transform.position = End_position.position;
        Producer_Btn.transform.position = Producer_End_Btn.position;
    }


    public void DotWeenEase()
    {
        Producer.transform.DOMove(Start_position.position, 0.5f).SetEase(Ease.OutBack);
        Producer_Btn.transform.DOMove(Producer_Start_Btn.position, 0.5f).SetEase(Ease.OutBack);
    }

}
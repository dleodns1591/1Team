using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Setting_Temp : MonoBehaviour
{
    [SerializeField] Image Setting;
    [SerializeField] Transform Start_position;
    [SerializeField] Transform End_position;
    [SerializeField] Transform Setting_Btn;
    [SerializeField] Transform Setting_Start_Btn;
    [SerializeField] Transform Setting_End_Btn;


    public void Start()
    {
        Initialize_01();
    }

    public void Update()
    {

    }

    public void Initialize()
    {
        Setting.transform.DOMove(End_position.position, 0.5f).SetEase(Ease.OutBack);
        Setting_Btn.transform.DOMove(Setting_End_Btn.position, 0.5f).SetEase(Ease.OutBack);
    }

    public void Initialize_01()
    {
        Setting.transform.position = End_position.position;
        Setting_Btn.transform.position = Setting_End_Btn.position;
    }


    public void DotWeenEase()
    {
        Setting.transform.DOMove(Start_position.position, 0.5f).SetEase(Ease.OutBack);
        Setting_Btn.transform.DOMove(Setting_Start_Btn.position, 0.5f).SetEase(Ease.OutBack);
    }

}
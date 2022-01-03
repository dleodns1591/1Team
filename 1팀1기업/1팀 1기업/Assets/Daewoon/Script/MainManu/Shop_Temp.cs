using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Shop_Temp : MonoBehaviour
{
    [SerializeField] Image Shop;
    [SerializeField] Transform Start_position;
    [SerializeField] Transform End_position;
    [SerializeField] Transform Shop_Btn;
    [SerializeField] Transform Shop_Start_Btn;
    [SerializeField] Transform Shop_End_Btn;


    public void Start()
    {
        Initialize_01();
    }

    public void Update()
    {

    }

    public void Initialize()
    {
        Shop.transform.DOMove(End_position.position, 0.5f).SetEase(Ease.OutBack);
        Shop_Btn.transform.DOMove(Shop_End_Btn.position, 0.5f).SetEase(Ease.OutBack);
    }

    public void Initialize_01()
    {
        Shop.transform.position = End_position.position;
        Shop_Btn.transform.position = Shop_End_Btn.position;
    }


    public void DotWeenEase()
    {
        Shop.transform.DOMove(Start_position.position, 0.5f).SetEase(Ease.OutBack);
        Shop_Btn.transform.DOMove(Shop_Start_Btn.position, 0.5f).SetEase(Ease.OutBack);
    }

}
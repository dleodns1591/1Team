using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Thunder,
    Booster,
    HpItem
}
public class Itemspawner : MonoBehaviour
{
    //아니 아이템 스포너가 있었네?
    public GameObject Thunder;
    public GameObject Booster;
    public GameObject HpItem;

   
    public void Spawn(ItemType itemType,Vector3 spawnPoint)
    {
        
        switch (itemType)
        {
            case ItemType.Thunder:
                Instantiate(Thunder,spawnPoint,Quaternion.Euler(0,0,0));
                break;
            case ItemType.Booster:
                Instantiate(Booster,spawnPoint,Quaternion.Euler(0,0,0));
                break;
            case ItemType.HpItem:
                Instantiate(HpItem, spawnPoint, Quaternion.Euler(0,0,0));
                break;
            default:
                Debug.Assert(false);
                break;
        }
    }
   

}

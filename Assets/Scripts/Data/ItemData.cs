using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData_", menuName = "Data/ItemData", order = 1)]
public class ItemData : ScriptableObject
{
    public string itemName;
    public int price;
    public bool isEquiped;
    public int itemType;
    // 0이면 무기, 1이면 방어구
    public int itemStats;
    // itemType이 0이면 공격력, 1이면 방어력
    public Sprite image;
}

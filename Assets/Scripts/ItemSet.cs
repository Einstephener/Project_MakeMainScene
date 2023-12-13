using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Item
{
    public string ItemName { get; } // 아이템 이름
    public int ItemGold { get; } // 아이템 가격
    public string ItemDescription { get; } // 아이템 상세 설명

    public Item(string itemName, int itemGold, string itemDescription)
    {
        ItemName = itemName;
        ItemGold = itemGold;
        ItemDescription = itemDescription;
    }
}
public class Weapon : Item    // 무기 클래스 (아이템을 상속받음)
{
    public int ItemStr { get; } // 공격력
    public int ItemDef { get; } // 공격력
    public int ItemHp { get; } // 체력
    public bool isEquipped { get; set; } //장착여부

    public Weapon(string itemName, int itemGold, string itemDescription, int itemStr, int itemDef, int itemHp, bool isEquipped = false)
        : base(itemName, itemGold, itemDescription)
    {
        ItemStr = itemStr;
        ItemDef = itemDef;
        ItemHp = itemHp;
    }

}
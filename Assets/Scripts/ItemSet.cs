using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Item
{
    public string ItemName { get; } // ������ �̸�
    public int ItemGold { get; } // ������ ����
    public string ItemDescription { get; } // ������ �� ����

    public Item(string itemName, int itemGold, string itemDescription)
    {
        ItemName = itemName;
        ItemGold = itemGold;
        ItemDescription = itemDescription;
    }
}
public class Weapon : Item    // ���� Ŭ���� (�������� ��ӹ���)
{
    public int ItemStr { get; } // ���ݷ�
    public int ItemDef { get; } // ���ݷ�
    public int ItemHp { get; } // ü��
    public bool isEquipped { get; set; } //��������

    public Weapon(string itemName, int itemGold, string itemDescription, int itemStr, int itemDef, int itemHp, bool isEquipped = false)
        : base(itemName, itemGold, itemDescription)
    {
        ItemStr = itemStr;
        ItemDef = itemDef;
        ItemHp = itemHp;
    }

}
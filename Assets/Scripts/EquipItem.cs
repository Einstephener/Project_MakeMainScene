using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipItem : MonoBehaviour
{
    private InventoryManager inventoryManager;
    private bool ItemEquip;
    private void Start()
    {
        inventoryManager = InventoryManager.instance;

    }
    public void Equip()
    {
        GameObject Item = transform.Find("IsEquip").gameObject;
        if (Item != null)
        {
            if (Item.activeSelf == true)
            {
                Debug.Log("Equip버튼이있음");
                ItemEquip = true;   
                Item.SetActive(false);

            }
            else
            {
                Debug.Log("Equip버튼이 없음");
                Item.SetActive(true);
            }
        }
        else {Debug.Log("아이템 장착여부 아이콘이 없습니다.");};
    }
}

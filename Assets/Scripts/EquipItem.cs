using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipItem : MonoBehaviour
{
    private InventoryManager inventoryManager;
    
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
                Debug.Log("Equip��ư������");
                Item.SetActive(false);
            }
            else
            {
                Debug.Log("Equip��ư�� ����");
                Item.SetActive(true);
            }
        }
    }
}

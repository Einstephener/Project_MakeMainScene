﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipItem : MonoBehaviour
{
    [SerializeField] private GameObject EquipCheckPanel;
    private InventoryManager inventoryManager;
    private bool ItemEquip;
    private void Start()
    {
        inventoryManager = InventoryManager.instance;

    }
    public void Equip()
    {
        GameObject Item = transform.Find("IsEquip").gameObject;
        EquipCheckPanel.SetActive(true);
        if (Item != null)
        {
            if (Item.activeSelf == true)
            {
                Debug.Log("Equip아이콘을 뺌");

                Item.SetActive(false);

            }
            else
            {
                Debug.Log("Equip아이콘을 킴");
                Item.SetActive(true);
            }
        }
        else {Debug.Log("아이템 장착여부 아이콘이 없습니다.");};
    }
    public void EquipIconOn()
    {

    }
}

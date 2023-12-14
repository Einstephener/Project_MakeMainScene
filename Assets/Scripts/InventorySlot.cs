using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    public EquipItem[] itemslots;

    public void SetInventory()
    {
        for (int i =0; i < InventoryManager.instance.gameData.myItems.Length; i++)
        {
            itemslots[i].Init(InventoryManager.instance.gameData.myItems[i]);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Items
{
    woodenSword,
    woodenShield,
    oldPot
}
public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    [SerializeField] private GameObject IsEquip;

    public bool ItemEquip;


    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        
    }

}

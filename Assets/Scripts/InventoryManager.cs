using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Items
{
    woodenSword,
    woodenShield,
    bicycleHelmet
}
public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    [SerializeField] private GameObject IsEquip;


    List<GameObject> HideBtnList = new List<GameObject>(); 
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        
    }

}

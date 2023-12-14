using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipItem : MonoBehaviour
{
    [SerializeField] private GameObject EquipCheckPanel;
    [SerializeField] private GameObject UnEquipCheckPanel;
    private GameObject Item;
    public ItemData inputData;
    public UserData userData;
    public Image itemImage;


    private void Awake()
    {
        Item = transform.Find("IsEquip").gameObject;
    }
    public void Equip()
    {
        if (Item != null)
        {
            EquipCheckPanel.GetComponent<PopUpControl>().Yes.onClick.RemoveAllListeners();
            UnEquipCheckPanel.GetComponent<PopUpControl>().Yes.onClick.RemoveAllListeners();
            if (Item.activeSelf == true) //끄기
            {
                UnEquipCheckPanel.GetComponent<PopUpControl>().Yes.onClick.AddListener(EquipIconOff);
                inputData.isEquiped = false;                
                UnEquipCheckPanel.SetActive(true);
            }
            else //켜기
            {
                EquipCheckPanel.GetComponent<PopUpControl>().Yes.onClick.AddListener(EquipIconOn);
                inputData.isEquiped = true; 
                EquipCheckPanel.SetActive(true);
            }
            
        }
    }

    public void EquipIconOff()
    {
        Item.SetActive(false);
    }
    public void EquipIconOn()
    {
        Item.SetActive(true);
    }

    public void Init(ItemData data)
    {
        inputData = data;
        itemImage.sprite = data.image;

        ChangeEquip(inputData);
    }

    public void ChangeEquip(ItemData data)
    {
        if (data.isEquiped)//아이템 스탯 적용
        {
            if (data.itemType == 0)
            {
                userData.atk += data.itemStats;
            }
            else if (data.itemType == 1)
            {   
                userData.def += data.itemStats;
            }
        }
        else
        {
            if (data.itemType == 0)
            {
                userData.atk -= data.itemStats;
            }
            else if (data.itemType == 1)
            {
                userData.def -= data.itemStats;
            }
        }
    }
}

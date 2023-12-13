using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipItem : MonoBehaviour
{
    [SerializeField] private GameObject EquipCheckPanel;
    [SerializeField] private GameObject UnEquipCheckPanel;
    private GameObject Item;
    private void Awake()
    {
        Item = transform.Find("IsEquip").gameObject;
    }
    public void Equip()
    {
        if (Item != null)
        {
            EquipCheckPanel.GetComponent<EquipCheck>().Yes.onClick.RemoveAllListeners();
            UnEquipCheckPanel.GetComponent<EquipCheck>().Yes.onClick.RemoveAllListeners();
            if (Item.activeSelf == true) //끄기
            {
                UnEquipCheckPanel.GetComponent<EquipCheck>().Yes.onClick.AddListener(EquipIconOff);
                UnEquipCheckPanel.SetActive(true);
            }
            else
            {
                EquipCheckPanel.GetComponent<EquipCheck>().Yes.onClick.AddListener(EquipIconOn);
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
}

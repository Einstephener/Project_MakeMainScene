using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipCheck : MonoBehaviour
{
    //[SerializeField] private Button checkBtn;
    [SerializeField] private GameObject popup;
    EquipItem equipItem;

    private void Awake()
    {
        equipItem = new EquipItem();
    }
    public void ClickYes()
    {
        popup.SetActive(false);
        equipItem.EquipIconOn();
    }
    public void ClickNo()
    {
        popup.SetActive(false);
    }

}

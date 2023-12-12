using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipCheck : MonoBehaviour
{
    //[SerializeField] private Button checkBtn;
    [SerializeField] private GameObject popup;

    public void ClickYes()
    {
        popup.SetActive(false);
    }
    public void ClickNo()
    {
        popup.SetActive(false);
    }

}

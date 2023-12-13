using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipCheck : MonoBehaviour
{
    [SerializeField] private GameObject popup;
    [SerializeField] public Button Yes;

    public void ClickBtn()
    {
        popup.SetActive(false);
    }
}

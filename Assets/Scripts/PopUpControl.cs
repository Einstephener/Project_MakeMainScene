using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpControl : MonoBehaviour
{
    [SerializeField] private GameObject popup;
    public Button Yes;

    public void ClickBtn()
    {
        popup.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClosedBtn : MonoBehaviour
{
    public GameObject Panel;
    public GameObject CharacterBtns;

    public void CloseBtn()
    {
        Panel.SetActive(false);
        CharacterBtns.SetActive(true);
    }

    public void OpenBtn()
    {
        Panel.SetActive(true);
        CharacterBtns.SetActive(false);
    }
}

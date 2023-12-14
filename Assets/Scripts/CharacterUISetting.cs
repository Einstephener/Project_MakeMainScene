using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterUISetting : MonoBehaviour
{
    public TMP_Text coinCount;
    public TMP_Text characterName;
    public TMP_Text description;
    [SerializeField] private UserData userData; 

    private void Start()
    {
        coinCount.text = userData.gold.ToString();
        characterName.text = userData.nickname.ToString();
        description.text = userData.description.ToString();
    }
}

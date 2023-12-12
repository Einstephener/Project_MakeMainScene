using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCount : MonoBehaviour
{
    public TMP_Text coinCount;
    private CharacterStats characterStats = new CharacterStats();

    private void Start()
    {
        coinCount.text = characterStats.PlayerGold.ToString();        
    }
}

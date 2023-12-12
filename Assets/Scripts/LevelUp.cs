using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour
{
    private CharacterStats characterStats = new CharacterStats();

    [SerializeField] private Slider experienceGaugeSlider;
    [SerializeField] private TMP_Text levelTxt;

    private float experience;
    private int level;


    private void Awake()
    {
       //characterStats = GetComponent<CharacterStats>();
    }
    private void Start()
    {
        experience = characterStats.CharacterExperience;
        level = characterStats.CharacterLevel;

        LevelUpdate();
    }
    private void LevelUpdate()
    {        
        RequiredExperience();
    }
    
    private void RequiredExperience()
    {
        if (experience > 10f) //경험치통은 일단 10으로 제작.
        {
            level++;
            experience -= 10f;
        }
        levelTxt.text = level.ToString();
        ExperienceUpdate();
    }

    private void ExperienceUpdate()
    {
        experienceGaugeSlider.value = experience / 10f;
    }
}

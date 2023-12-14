using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour
{

    [SerializeField] private Slider experienceGaugeSlider;
    [SerializeField] private TMP_Text levelTxt;
    [SerializeField] private UserData userData;

    private float experience;
    private int level;

    private void Start()
    {        
        LevelUpdate();
    }
    private void LevelUpdate()
    {
        experience = userData.exp;
        level = userData.userLV;

        RequiredExperience();
    }
    
    private void RequiredExperience()
    {
        if (experience > 10f) //����ġ���� �ϴ� 10���� ����.
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

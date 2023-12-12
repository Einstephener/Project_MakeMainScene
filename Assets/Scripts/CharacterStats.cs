using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatsChangeType
{
    Add,
    Multiple,
    Override,
}

[Serializable]
public class CharacterStats
{
    public StatsChangeType statsChangeType;
    public float Attack;
    public float Defence;
    public int maxHealth;
    public int Critical;
    public int PlayerGold = 10000;
    public int CharacterLevel = 9;
    public float CharacterExperience = 8f;
    //임시 값 저장
}
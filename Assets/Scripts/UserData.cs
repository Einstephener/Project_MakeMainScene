using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UserData_", menuName = "Data/UserData", order =0)]
public class UserData : ScriptableObject
{
    public string nickname;
    public int userLV;
    public float exp;
    public string description;
    public int gold;

    public int atk;
    public int def;
    public int hp;
    public int cri;
        
}

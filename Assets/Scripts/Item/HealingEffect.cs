using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ItemEffect/Consumable/Health")]
public class HealingEffect : ItemEffect
{
    public int healthPoint = 0;
    public override bool ExecuteRole()
    {
        Debug.Log("PlayerHpAdd : " +  healthPoint);
        return true;
    }
}

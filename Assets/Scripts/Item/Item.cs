using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum itempType
{
    Equipment,
    Consumables
}

[System.Serializable]
public class Item
{
    public itempType itemType;
    public string itemName;
    public Sprite itemImage;
    public List<ItemEffect> efts; 

    public bool Use()
    {
        bool isUsed = false;
        foreach (ItemEffect effect in efts)
        {
            isUsed = effect.ExecuteRole();
        }


        return isUsed;
    }

    public bool Equipment()
    {
        bool isEquip = false;

        isEquip = true;

        return isEquip; 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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


    public bool Use()
    {
        return false;
    }
}

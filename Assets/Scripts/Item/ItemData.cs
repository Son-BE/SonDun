using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemData : MonoBehaviour
{
    public static ItemData instance;

    public int money = 0;
    private void Awake()
    {
        instance = this;
    }

    public List<Item> itemData = new List<Item>();
    public GameObject ItemPrefab;


    private void Start()
    {
        money = 1500;
        
    }
}

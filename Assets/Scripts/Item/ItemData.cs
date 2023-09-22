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
    public GameObject dropItemPrefab;
    public Vector2[]pos;

    private void Start()
    {
        for(int i = 0; i< 5; i++)
        {
            GameObject go = Instantiate(dropItemPrefab, pos[i],Quaternion.identity);
            go.GetComponent<DropItem>().SetItem(itemData[Random.Range(0,3)]);
        }
        
        money = 1500;
        
    }
}

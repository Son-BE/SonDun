using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public delegate void OnSlotCountChange(int val);
    public OnSlotCountChange onSlotCountChange;

    
    private int slotCount;
    public int SlotCount
    {   
        get => slotCount;
        set
        {
            slotCount = value;
            onSlotCountChange.Invoke(slotCount);
        }
    }

    #region Singleton
    public static Inventory Instance;
    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }
    #endregion

    void Start()
    {
        SlotCount = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

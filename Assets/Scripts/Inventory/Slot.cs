using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class Slot : MonoBehaviour,IPointerUpHandler
{
    public int slotnum;
    public Item item;
    public Image itemIcon;


    public bool isShopMode;

    public void UpdateSlotUI()
    {
        itemIcon.sprite = item.itemImage;
        itemIcon.gameObject.SetActive(true);
    }

    public void RemoveSlot()
    {
        item = null;
        itemIcon.gameObject.SetActive(false);
    }
        
    public void OnPointerUp(PointerEventData eventData)
    {
        bool isUse = item.Use();
        if(isUse)
        {
            Inventory.Instance.RemoveItem(slotnum);
        }
    }

}



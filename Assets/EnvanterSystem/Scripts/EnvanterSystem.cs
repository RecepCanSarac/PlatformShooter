using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EnvanterSystem : MonoBehaviour
{
    public static EnvanterSystem instance { get; private set; }
    private void Awake()
    {
        instance = this;
    }


    public List<SlotUI> Slots = new List<SlotUI>();

    public List<GameObject> Sprites = new List<GameObject>();

    public static int slotIndex;

    private int y = 0;
    private void Start()
    {
        for (int i = 0; i < Slots.Count; i++)
        {
            Slots[i].index = i;
        }
    }
    private void SlotCheck()
    {
        int index = 0;
        int index2 = 0;
        foreach (var slot in Slots)
        {
            if (slot.isFull == true)
            {
                index++;

            }
            else if (slot.isFull == false)
                index2 = Slots.Count - index;
        }
        Debug.Log("Dolu Slot Sayýsý" + index);
        Debug.Log("Boþ Slot Sayýsý" + index2);
        if (index2 == 0)
            Debug.Log("Slotlarýn hepsi Doludur Lütfen Item Satýn Almaya Çalýþmayýn");
    }


    private void SetSlotItem(GameObject item, int slotIndex)
    {
        if (Slots[slotIndex].isFull == false)
        {
            GameObject _item = Instantiate(item, Slots[slotIndex].transform);
            Slots[slotIndex].isFull = true;
        }
    }

    public void ItemProducer()
    {
        int x = Random.Range(0, Sprites.Count);
        SetSlotItem(Sprites[x], y);
        y = 0;
        foreach (var item in Slots)
            if (item.isFull)
                y += 1;
            else
                y -= 1;
        SlotCheck();
    }


    public void ItemDelete()
    {
        Debug.Log(slotIndex);
        var item = Slots[slotIndex].transform.GetChild(0).gameObject;
        if (item != null)
        {
            Destroy(item);
            Slots[slotIndex].isFull = false;
        }
    }

}

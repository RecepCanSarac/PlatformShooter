using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotUI : MonoBehaviour
{
    public bool isFull;
    public int index;
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(IndexOfIndex);
    }

    public void IndexOfIndex()
    {
        EnvanterSystem.slotIndex = index;
        Debug.Log(EnvanterSystem.slotIndex);
    }
}

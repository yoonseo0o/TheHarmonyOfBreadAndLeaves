using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrayManager : MonoBehaviour
{
    public TrayHandler[] HTray;

    public void InitTrays()
    {
        for(int i=0;i<HTray.Length;i++)
        {
            HTray[i].ID = i;
        }
    }

    public bool IsFull()
    {
        if (HTray == null)
        {
            Debug.LogError("HTray NULL - IsFull()");
            return false;
        }
        foreach (var e in HTray)
        {
            if (e.sandwich == null) return false;
        }
        return true;
    }
    public int GetEmptySlotIndex()
    {
        for(int i = 0; i < HTray.Length;i++)
        {
            if(HTray[i].sandwich==null)
                return i;
        }
        return -1;
    }
    public Sandwich AutoPutBread(IngredientBase bread)
    {
        if(IsFull())
        {
            Debug.Log("모든 트레이가 꽉 차있음");
            return null;
        }
        Debug.Log("자동 빵 놓기");
        if (GetEmptySlotIndex() == -1)
            Debug.LogError("GetEmptySlotIndex()");
        return HTray[GetEmptySlotIndex()].put(bread);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientHandler : MonoBehaviour
{
    [SerializeField] private IngredientBase data; 
    public IngredientBase Data { get { return data; } } 

    public GameObject Pick(Transform Cursor)
    {
        Debug.Log($"{name}�� ���ȴ�!");
        switch(data.BaseType)
        {
            case IngredientBaseType.Bread:
                Debug.Log("���� Ŭ���߽��ϴ�");
                break;
            case IngredientBaseType.Ingredient:
                Instantiate(data.Prefab, Cursor);
                break;
            case IngredientBaseType.Sauce:
                Instantiate(data.Prefab, Cursor);
                break;
        }
        return data.Prefab;
    }
}

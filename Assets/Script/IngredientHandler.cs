using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientHandler : MonoBehaviour
{
    [SerializeField] private IngredientBase data; 
    public IngredientBase Data { get { return data; } } 

    public GameObject Pick(Transform Cursor)
    {
        Debug.Log($"{name}이 눌렸다!");
        switch(data.BaseType)
        {
            case IngredientBaseType.Bread:
                Debug.Log("빵은 못 집어용 대신 자동으로 놔줄게용");
                GameManager.Instance.TrayManager.AutoPutBread(data);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientHandler : MonoBehaviour
{
    Vector3 m_vecMouseDownPos;
    [SerializeField] private IngredientBase data; 
    public IngredientBase Data { get { return data; } }
    void Start()
    {
        
    }
    public GameObject Pick(Transform Cursor)
    {
        Debug.Log($"{name}¿Ã ¥≠∑»¥Ÿ!");
        Instantiate(data.Prefab, Cursor);
        return data.Prefab;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum IngredientBaseType { Bread,Ingredient,Sauce};
public class IngredientBase : ScriptableObject
{
    private int price;
    [SerializeField] private bool RequiresCutting; // 썰어야하는지
    [SerializeField] private GameObject prefab;
    public GameObject Prefab { get { return prefab; } }
    [SerializeField] private IngredientBaseType baseType;
    public IngredientBaseType BaseType { get { return baseType; } }

}

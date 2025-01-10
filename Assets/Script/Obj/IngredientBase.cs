using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum IngredientBaseType { Bread,Ingredient,Sauce};
public class IngredientBase : ScriptableObject
{
    [SerializeField] private int price;
    public int Price { get { return price; } } 
    [SerializeField] private bool RequiresCutting; // 썰어야하는지
    public virtual bool AutoPlacement { get; protected set; } = false;  // 자동배치 
    [SerializeField] private GameObject prefab;
    public GameObject Prefab { get { return prefab; } }
    [SerializeField] private IngredientBaseType baseType;
    public IngredientBaseType BaseType { get { return baseType; } }
    public virtual Sandwich put(Sandwich sandwich) 
    {
        if(sandwich == null)
        {
            Debug.Log("sandwich null");
            return null;
        }
        Debug.Log("base class");
        sandwich.price = price;
        return sandwich; 
    }
}

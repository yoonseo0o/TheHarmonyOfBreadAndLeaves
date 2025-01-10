using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum IngredientType { Ham,Cheeze,Lettuce,Tomato,Count};
[CreateAssetMenu(fileName = "IngredientData", menuName = "Scriptable Object/IngredientData", order = int.MaxValue)]
public class Ingredient : IngredientBase
{ 
    [SerializeField] private IngredientType type;
    public IngredientType Type { get { return type; } }

    public Ingredient() { AutoPlacement = false; }

    public override Sandwich put(Sandwich sandwich)
    {
        base.put(sandwich);
        Debug.Log("Ingredient class");
        sandwich.ingredients[(int)type]++;
        return sandwich;
    }
}

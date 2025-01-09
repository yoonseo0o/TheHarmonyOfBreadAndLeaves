using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum IngredientType { Ham,Cheeze,Lettuce,Tomato};
[CreateAssetMenu(fileName = "IngredientData", menuName = "Scriptable Object/IngredientData", order = int.MaxValue)]
public class Ingredient : IngredientBase
{ 
    [SerializeField] private IngredientType type;
    public IngredientType Type { get { return type; } }


}

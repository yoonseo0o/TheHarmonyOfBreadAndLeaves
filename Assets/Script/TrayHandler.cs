using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrayHandler : MonoBehaviour
{
    public int ID { get; set; }
    public Sandwich sandwich;
    public TextMesh text;
    public Sandwich put(IngredientBase ingredient)
    {
        if (ingredient.BaseType == IngredientBaseType.Bread)
        {
            sandwich += ingredient;
        }
        if (sandwich == null)
        {
            Debug.Log("빵을 먼저 놓아주세요");
            return null;
        }
        if (ingredient.BaseType != IngredientBaseType.Bread)
        {
            sandwich += ingredient;
        }

        text.text = sandwich.ShowSandwich();
        return sandwich;
    }
}

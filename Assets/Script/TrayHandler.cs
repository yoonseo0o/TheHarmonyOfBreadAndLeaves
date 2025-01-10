using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrayHandler : MonoBehaviour
{
    public Sandwich sandwich;
    public TextMesh text;
    public void put(IngredientBase ingredient)
    {
        if(ingredient.BaseType == IngredientBaseType.Bread)
        {
            sandwich += ingredient;
        }
        if (sandwich == null)
        {
            Debug.Log("���� ���� �����ּ���");
            return;
        }
        if (ingredient.BaseType != IngredientBaseType.Bread)
        {
            sandwich += ingredient;
        }
        
        text.text = sandwich.ShowSandwich();
    }
}

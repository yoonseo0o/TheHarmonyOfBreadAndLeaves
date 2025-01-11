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
            Debug.Log("���� ���� �����ּ���");
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

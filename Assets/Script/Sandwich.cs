using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sandwich
{
    public int bread;
    public int[] ingredients;
    public int[] sauces;

    public int price;
   
    public Sandwich() { }
    public Sandwich(BreadType breadType) 
    { 
        bread = (int)breadType;
        ingredients = new int[(int)IngredientType.Count];
        sauces = new int[(int)SauceType.Count];
    }
    public static Sandwich operator +(Sandwich mySandwich, IngredientBase ingredient)
    {
        return ingredient.put(mySandwich);
    }
    public string ShowSandwich()
    {
        string[] breadText = { "위트", "베이글" };  
        string[] ingredientText = { "햄","치즈","양상추","토마토" };
        string[] sauceText = { "케찹","머스타드" };
        string str = breadText[bread]; 
        for(int i = 0; i < ingredients.Length; i++)
        {
            if (ingredients[i]>0)
            {
                str += " "+ingredientText[i];
            }
        }
        for (int i = 0; i < sauces.Length; i++)
        {
            if (sauces[i] > 0)
            {
                str += " " + sauceText[i];
            }
        }
        Debug.Log(str);
        return str;
    }
}

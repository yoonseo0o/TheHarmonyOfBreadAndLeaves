using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SauceType { Ketchup, Mustard, Count };
[CreateAssetMenu(fileName = "SauceData", menuName = "Scriptable Object/SauceData", order = int.MaxValue)]
public class Sauce : IngredientBase
{

    [SerializeField] private SauceType type;
    public SauceType Type { get { return type; } }

    public Sauce() { AutoPlacement = false; }
    public override Sandwich put(Sandwich sandwich)
    {
        base.put(sandwich);
        Debug.Log("Sauce class");
        sandwich.sauces[(int)type]++;
        return sandwich;
    }
}

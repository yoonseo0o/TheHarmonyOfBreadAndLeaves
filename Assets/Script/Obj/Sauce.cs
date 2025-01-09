using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SauceType { Ketchup, Mustard };
[CreateAssetMenu(fileName = "SauceData", menuName = "Scriptable Object/SauceData", order = int.MaxValue)]
public class Sauce : IngredientBase
{

    [SerializeField] private SauceType type;
    public SauceType Type { get { return type; } }



}

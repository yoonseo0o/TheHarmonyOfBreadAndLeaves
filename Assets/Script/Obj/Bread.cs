using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BreadType { Wheat,Bagel };
[CreateAssetMenu(fileName = "BreadData", menuName = "Scriptable Object/BreadData", order = int.MaxValue)]
public class Bread : IngredientBase
{
    [SerializeField] private BreadType type;
    public BreadType Type { get { return type; } }

}

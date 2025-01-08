using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BreadType { Wheat,Bagel };
public class Bread : IngredientBase
{
    private BreadType type;
    private bool RequiresCutting; // 썰어야하는지
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum BreadType { Wheat,Bagel };
[CreateAssetMenu(fileName = "BreadData", menuName = "Scriptable Object/BreadData", order = int.MaxValue)]
public class Bread : IngredientBase
{
    [SerializeField] private BreadType type;
    public BreadType Type { get { return type; } }
    public Bread() { AutoPlacement = true; }
    public override Sandwich put(Sandwich sandwich)
    {

        if(sandwich!=null)
        {
            Debug.Log("트레이에 샌드위치가 존재합니다.");
            return sandwich;
        }
        Sandwich mySandwich = new Sandwich(type);
        base.put(mySandwich);
        Debug.Log("Bread class");
        return mySandwich;
    } 
}

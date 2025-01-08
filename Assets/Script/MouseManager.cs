using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public enum GameLayers
{
    Ingredient = 6
}
public class MouseManager : MonoBehaviour
{
    [SerializeField] Transform CursorObj;
    private Vector3 CursorPos;
    private Vector3 CursorObjPos;
    void Start()
    {
        CursorPos = Input.mousePosition;
        CursorObjPos = CursorObj.position;
    }

    void Update()
    {
        //Debug.Log(CursorPos - Input.mousePosition);
        CursorObj.localPosition = CursorObjPos + new Vector3(Input.mousePosition.x - CursorPos.x, 0, Input.mousePosition.y - CursorPos.y) / 50;

        if (Input.GetMouseButtonDown(0))
        {
            OnMouseDown();
        }
    }
    private void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit; 
        if (Physics.Raycast(ray, out hit, 100.0f))
        { 
            switch (hit.transform.gameObject.layer)
            {
                case (int)GameLayers.Ingredient:
                    {
                        //Debug.Log(hit.transform.name);
                        if (hit.transform.gameObject.GetComponent<IngredientHandler>() == null)
                            Debug.LogError("선택한 오브젝트에 IngredientHandler가 존재하지 않습니다.");
                        hit.transform.gameObject.GetComponent<IngredientHandler>().Pick();

                        break;
                    }
                default:
                    break;
            }


        }
    }
}

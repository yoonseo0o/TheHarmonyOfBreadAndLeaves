using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public enum GameLayers
{
    Ingredient = 6,
    Tray = 7
}
public class MouseManager : MonoBehaviour
{
    [SerializeField] Transform CursorObj;
    private float fixedYPosition;
    private GameObject IngredientPrefab;
    private bool IsPick;
    void Start()
    {
        fixedYPosition = CursorObj.position.y;
        Debug.Log(fixedYPosition);
    }

    void Update()
    {
        MoveCursor();
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
                        IngredientHandler handler = hit.transform.gameObject.GetComponent<IngredientHandler>();

                        if (handler == null)
                        {
                            Debug.LogError("������ ������Ʈ�� IngredientHandler�� �������� �ʽ��ϴ�.");
                            break;
                        }

                        if (IsPick && CursorObj.childCount > 1)
                        {
                            Destroy(CursorObj.GetChild(1).gameObject);
                        }

                        IngredientPrefab = handler.Pick(CursorObj);
                        if (handler.Data.BaseType != IngredientBaseType.Bread)
                        {
                            IsPick = true;
                        }
                        else
                        {
                            Debug.Log("���� �ö󰬽��ϴ�.");
                        }
                        break;
                    }
                case (int)GameLayers.Tray:
                    {
                        if (IsPick)
                        {
                            if(IngredientPrefab == null)
                            {
                                Debug.LogError("IngredientPrefab NULL");
                                break;
                            }
                            // ������ġ ���� �ȵ��ִٸ� ������ġ ����
                            // ������ġ�� ��� ����
                            Debug.Log($"������ġ�� {CursorObj.GetChild(1).name}�� �ö󰬽��ϴ�.");
                            
                            //IngredientPrefab = null;
                            //IsPick = false;
                        }
                        break;
                    }
                default:
                    break;
            }


        }
    }

    private void MoveCursor()
    {
        Vector3 mousePosition = Input.mousePosition;

        Ray ray = Camera.main.ScreenPointToRay(mousePosition);
        Plane zPlane = new Plane(Vector3.up, new Vector3(0, fixedYPosition, 0));
        if (zPlane.Raycast(ray, out float distance))
        {
            Vector3 worldPosition = ray.GetPoint(distance);
            //Debug.DrawRay(ray.origin, ray.direction * distance, Color.green);
            CursorObj.transform.position = worldPosition;
        }
    }
}

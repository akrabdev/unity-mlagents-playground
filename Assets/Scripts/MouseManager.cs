using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseManager : MonoBehaviour
{
    //Know what objects are clickable
    public LayerMask clickableLayer;

    public int publicIntTest;

    //swap cursors per object
    public Texture2D pointer; //normal cursor
    public Texture2D target; //for clickable world objects
    public Texture2D doorway; //Doorways
    public Texture2D combat; //for combat actions

    public EventVector3 onClickEnvironment;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 50, clickableLayer.value))
        {
            bool door = false;
            bool item = false;

            if (hit.collider.gameObject.tag == "Doorway")
            {
                Cursor.SetCursor(doorway, new Vector2(16, 16), CursorMode.Auto);
                door = true;
            }
            else if (hit.collider.gameObject.tag == "Item")
            {
                Cursor.SetCursor(combat, new Vector2(16, 16), CursorMode.Auto);
                item = true;
            }
            else
            {
                Cursor.SetCursor(target, new Vector2(16, 16), CursorMode.Auto);
            }

            if (Input.GetMouseButtonDown(0))
            {
                if (door)
                {
                    Transform doorway = hit.collider.gameObject.transform;
                    onClickEnvironment.Invoke(doorway.position);
                    Debug.Log("DOOR");
                }
                else if (item)
                {
                    Transform itemPos = hit.collider.gameObject.transform;
                    onClickEnvironment.Invoke(itemPos.position);
                    Debug.Log("ITEM");
                }
                else
                {
                    onClickEnvironment.Invoke(hit.point);
                }
            }

        }

        else
        {
            Cursor.SetCursor(pointer, Vector2.zero, CursorMode.Auto);
        }
    }
}

[System.Serializable]
public class EventVector3 : UnityEvent<Vector3> { }
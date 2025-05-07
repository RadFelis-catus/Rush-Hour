using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*The purpose of this script is to move a vehicle up, down, left, or right 
dependings on its orientation. Movement will occur when the player clicks and drags a vehicle in the intended direction.*/
public class MoveScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector3 screenPoint;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    //called when mouse is clicked
    void OnMouseDown() {
        Debug.Log("Mouse clicked on: " + gameObject.name);
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position); //transforms world position of gameObject into screen coords
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z)); //offset = distance of gameObject from camera
    }

    void OnMouseDrag() {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z); //finds screen coords of cursor
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset; //determines world position of cursor, then adds distance from camera
        transform.position = curPosition; //moves gameObject to cursor position
    }
}

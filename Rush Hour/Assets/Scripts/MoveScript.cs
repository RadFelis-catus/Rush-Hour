using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*The purpose of this script is to move a vehicle up, down, left, or right 
dependings on its orientation. Movement will occur when the player clicks and drags a vehicle in the intended direction.*/
public class MoveScript : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move() {
        if (Input.GetMouseButtonDown(0)) {
            mousePos = Input.mousePosition;
            Debug.Log("Mouse pressed down at: " + mousePos);
        }
    }

    void OnMouseDrag() {
        
    }
}

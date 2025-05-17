using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*The purpose of this script is to move a vehicle up, down, left, or right 
dependings on its orientation. Movement will occur when the player clicks and drags a vehicle in the intended direction.*/
public class MoveScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector3 curScreenPoint;
    private Vector3 curWorldPoint;
    private Vector3 offset;
    private Vector3 carScreenPoint;
    private bool hit;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        //Debug.Log("This script is running");
    }

    void OnMouseUp() {
        hit = false;
    }

    void OnMouseDrag() {
        //Debug.Log("OnMouseDrag called");
        if (!hit && !WinScript.end) {
            if(transform.CompareTag("Vehicle") || transform.CompareTag("Player")) {
                //Debug.Log("Mouse is on the corrrect collider");
                carScreenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

                if (ConstraintScript.HasConstraint(rb.constraints, RigidbodyConstraints2D.FreezePositionX)) {
                    curScreenPoint = new Vector3(carScreenPoint.x, Input.mousePosition.y, carScreenPoint.z);

                }else if (ConstraintScript.HasConstraint(rb.constraints, RigidbodyConstraints2D.FreezePositionY)) {
                    curScreenPoint = new Vector3(Input.mousePosition.x, carScreenPoint.y, carScreenPoint.z);

                }else {
                    //Debug.Log("This object is not constrained");
                }

                curWorldPoint = Camera.main.ScreenToWorldPoint(curScreenPoint);
                transform.position = curWorldPoint;
            }
        }
        
    }

    void OnCollisionEnter2D (Collision2D col) {
        if (col.gameObject != gameObject) {
            hit = true;
        }
    }
}
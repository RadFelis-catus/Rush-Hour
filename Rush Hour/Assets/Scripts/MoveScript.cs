using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*The purpose of this script is to move a vehicle up, down, left, or right 
dependings on its orientation. Movement will occur when the player clicks and drags a vehicle in the intended direction.*/
public class MoveScript : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] Vector3 screenPoint;
    [SerializeField] Vector3 curScreenPoint;
    [SerializeField] Vector3 curPosition;
    [SerializeField]Vector3 offset;
    [SerializeField] Vector3 origin;
    [SerializeField] Vector3 direction;
    [SerializeField] float maxDistance;
    [SerializeField] bool canMove;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        canMove = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0)) {
            //Debug.Log("The Left Mouse Button is being held down");
            Drag(); 
        }
    }

    void Drag() {
        //Debug.Log("Drag Method was called");
        
        origin = transform.position;
        direction = transform.TransformDirection(Vector3.forward);
        maxDistance = 0.5f;
        if (Physics.Raycast(origin, direction, maxDistance)) {
            Debug.Log("There is something in front of the object");
            canMove = false;
        }
        Debug.Log("canMove is: " + canMove);


        /*
        if (canMove) {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
            curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z); //finds screen coords of cursor
            curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset; //determines world position of cursor, then adds distance from camera
            gameObject.transform.position = curPosition; //moves gameObject to cursor position
        }
        */
        

        
    }
}

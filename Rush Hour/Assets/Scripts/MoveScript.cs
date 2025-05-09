using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*The purpose of this script is to move a vehicle up, down, left, or right 
dependings on its orientation. Movement will occur when the player clicks and drags a vehicle in the intended direction.*/
public class MoveScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector3 curScreenPoint;
    [SerializeField] Vector3 curPosition;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        if (Input.GetMouseButton(0)) {
            Debug.Log("Mouse held down");
            Vector3 mousePos = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                Debug.Log("Mouse is on a collider");
                if(hit.transform.CompareTag("Vehicle") || hit.transform.CompareTag("Player")) {
                    Debug.Log("Mouse is on the corrrect collider");
                    curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
                    curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
                    gameObject.transform.position = curPosition;
               }
            }
        }
    }
}

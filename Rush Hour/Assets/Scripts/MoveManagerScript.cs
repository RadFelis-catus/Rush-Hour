using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isEnd();
    }

    void isEnd() {
        if (WinScript.end) {
            Debug.Log("Vehicles can't move anymore");
            GetComponent<MoveScript>().enabled = false;
        }
    }
}

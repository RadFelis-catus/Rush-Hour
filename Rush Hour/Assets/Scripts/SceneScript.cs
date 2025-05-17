using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    private static int sceneNumber = -1;
    // Start is called before the first frame update
    void Start()
    {
        //SceneManager.LoadScene("StartScene");
        //sceneNumber = 0;
        //Debug.Log("Loading Scene: " + sceneNumber);
    }

    // Update is called once per frame
    void Update()
    {
        if (sceneNumber == -1) {
            sceneNumber++;
            SceneManager.LoadScene("StartScene");
            Debug.Log("Loading Scene: " + sceneNumber);
        }

        if (sceneNumber == 0 && Input.GetMouseButtonDown(0)) {
            sceneNumber++;
            SceneManager.LoadScene("GameScene");
            Debug.Log("Loading Scene: " + sceneNumber);
        }

        Restart();
    }

    void Restart() {
        if (WinScript.end && Input.GetKeyDown(KeyCode.R)) {
            Debug.Log("restart works!");
            sceneNumber = -1;
            WinScript.end = false;
        }
    }
}

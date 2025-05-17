using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinScript : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI restartText;
    public static bool end = false;
    // Start is called before the first frame update
    void Start()
    {
        gameOverText.gameObject.SetActive(false);
        restartText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.CompareTag("Player")) {
            gameOverText.gameObject.SetActive(true);
            restartText.gameObject.SetActive(true);
            end = true;
        }
    }
}

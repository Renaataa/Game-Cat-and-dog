using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverControl : MonoBehaviour
{
    private GameObject successPanel;
    private GameObject failurePanel;
    private GameObject gameOverCanvas;

    // Start is called before the first frame update
    void Start()
    {
        gameOverCanvas = GameObject.Find("GameOverCanvas");
        if(gameOverCanvas != null){
            failurePanel = gameOverCanvas.transform.GetChild(0).gameObject;
            successPanel = gameOverCanvas.transform.GetChild(1).gameObject;
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "ballon"){
            Debug.Log("Sukces!");
            successPanel.SetActive(true);
        }
        else if(other.gameObject.tag == "border"){
            Debug.Log("Porazka.");
            failurePanel.SetActive(true);
        }
    }
}

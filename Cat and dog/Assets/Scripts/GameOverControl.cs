using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "ballon"){
            Debug.Log("Sukces!");
        }
        else if(other.gameObject.tag == "border"){
            Debug.Log("Porazka.");
        }
    }
}

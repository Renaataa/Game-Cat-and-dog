using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    Animator anim;
    Rigidbody2D body;
    public float jumpForce;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HeroController.Start");
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("HeroController.Update");
        if (Input.GetMouseButtonDown(0) && isGrounded)
        {
            anim.SetTrigger("Jump");
            body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("HeroController.OnTriggerEnter2D");
        if(other.tag == "ground"){
            isGrounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D other){
        Debug.Log("HeroController.OnTriggerExit2D");
        if(other.tag == "ground"){
            isGrounded = false;
        }
    }
}

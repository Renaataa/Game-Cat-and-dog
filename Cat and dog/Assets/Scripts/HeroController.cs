﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    Animator anim;
    Rigidbody2D body;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Jump");
            body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour

{
    public float moveSpeed = 5f;

    public Rigidbody2D rb; 
    public Camera cam;

    Vector2 movement;
    Vector2 mousepos;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousepos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousepos - rb.position;
         float angle = Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg - 0f;
        rb.rotation = angle; 
    }
}

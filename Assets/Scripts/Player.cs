using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float torqueAmount;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float normalSpeed = 20f;
    SurfaceEffector2D surfaceEffector2D;
    Rigidbody2D rb2d;
    bool canMove = true;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindAnyObjectByType<SurfaceEffector2D>();
    }
    void Update()
    {
        if (canMove)
        {
        rotatePlayer();
        respondToBoost();
        }
    }

    public void disableControls()
    {
        canMove = false;
    }

    private void respondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else 
        {
            surfaceEffector2D.speed = normalSpeed;
        }
    }

    void rotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}

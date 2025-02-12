﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BoilerMovement : MonoBehaviour
{
    public new Transform transform;
    public GameObject player;
    public Vector2 target;
    public Vector2 force;
    public int ballspeed;
    public Vector3 BoilerPosition;
    public Vector3 pos
    {
        get
        {
            return transform.position;
        }
    }
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) )
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.LookAt(target, transform.up);
            GameManager.instance.OnDragStart();
            force = target - (Vector2)transform.position;
            FindObjectOfType<Trejectory>().UpdateDots(gameObject.transform.position, force);
        }
        if (Input.GetMouseButtonUp(0))
        {
            SpawnBall();
            GameManager.instance.OnDragEnd();
        }
    }
    public void SpawnBall()
    {
        Rigidbody2D rb = Instantiate(player, transform.position, player.transform.rotation).GetComponent<Rigidbody2D>();
        force = target - (Vector2)transform.position;
        rb.velocity = force;
    }
}

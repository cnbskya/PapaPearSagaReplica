using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BoilerMovement : MonoBehaviour
{
    public new Transform transform;
    public GameObject player;
    public Vector2 target;
    public int ballspeed;
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && GameManager.instance.isGameOn)
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.LookAt(target, transform.up);
        }
        if (Input.GetMouseButtonUp(0))
        {
            SpawnBall();
        }
    }
    public void SpawnBall()
    {
        Rigidbody2D rb = Instantiate(player, transform.position, player.transform.rotation).GetComponent<Rigidbody2D>();
        Vector2 force = target - (Vector2)transform.position;
        rb.velocity = force;
    }
}

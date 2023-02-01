using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float inputDirx;
    private float movDirx;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private int speed = 12;
    private void FixedUpdate()
    {
        movement();
    }

    private void movement()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            inputDirx = Input.GetAxis("Horizontal");
            movDirx = inputDirx * speed * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + new Vector2(movDirx, 0f));
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            inputDirx = Input.GetAxis("Vertical");
            movDirx = inputDirx * speed * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + new Vector2(0f, movDirx));
        }
    }
}

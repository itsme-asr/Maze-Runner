using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float inputDirx;
    private float movDirx;
    [SerializeField] private int speed = 12;
    private void Update()
    {
        movement();
    }

    private void movement()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            inputDirx = Input.GetAxisRaw("Horizontal");
            movDirx = inputDirx * speed * Time.deltaTime;
            transform.Translate(new Vector3(movDirx, 0f, 0f));
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            inputDirx = Input.GetAxisRaw("Vertical");
            movDirx = inputDirx * speed * Time.deltaTime;
            transform.Translate(new Vector3(0f, movDirx, 0f));
        }
    }
}

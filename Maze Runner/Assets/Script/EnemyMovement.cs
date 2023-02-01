using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed = 5;

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2(speed * Time.fixedDeltaTime, 0f));
        //rb.velocity = new Vector3(speed * Time.fixedDeltaTime, 0f, 0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }
}

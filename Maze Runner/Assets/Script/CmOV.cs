using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmOV : MonoBehaviour
{
    [SerializeField] private SpriteRenderer entrance;
    private float sub;
    [SerializeField] private Transform player;
    private void Start()
    {
        sub = 1;
    }
    void Update()
    {
        entrance.color = new Color(0, 0, 0, Random.Range(0, 100) * Time.deltaTime);
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}

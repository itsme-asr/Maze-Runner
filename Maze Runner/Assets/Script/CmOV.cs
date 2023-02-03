using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmOV : MonoBehaviour
{
    [SerializeField] private SpriteRenderer entrance;

    [SerializeField] private Transform player;

    void Update()
    {
        entrance.color = new Color(0, 0, 0, Random.Range(0, 35) * Time.deltaTime);
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }

}

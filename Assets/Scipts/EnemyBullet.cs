using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

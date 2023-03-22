using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = Jump.Instance.gameObject;

        Vector3 direction = player.transform.position - transform.position;
        this.transform.right = direction;
        rb.AddForce(direction.normalized * force, ForceMode2D.Impulse);
    }
}

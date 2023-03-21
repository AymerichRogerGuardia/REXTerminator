using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorGround : MonoBehaviour
{
    float moveInput;
    Rigidbody2D rb;
    public List<Vector3> points;
    public bool grounded;
    public bool walled;
    public GameObject groundRayObject;
    public LayerMask groundMask;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    private void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            RaycastHit2D hitGround = Physics2D.Raycast(groundRayObject.transform.position + (0.5f * Vector3.down), Vector2.down, 0.5f, groundMask);
            if (hitGround.collider != null)
            {
                grounded = true;
            }
        }
    }
}
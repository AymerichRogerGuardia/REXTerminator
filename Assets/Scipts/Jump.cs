using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomJump : MonoBehaviour
{
    [SerializeField] float jumpForce = 7;

    Rigidbody2D rb;

    // Start is called before the first frame update
    private void Start()
    {
      rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.AddForce(Vector2.up * jumpForce);
        }

    }
}


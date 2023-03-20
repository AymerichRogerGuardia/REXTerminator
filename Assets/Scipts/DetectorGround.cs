using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorGround : MonoBehaviour
{
    [SerializeField] BoxCollider2D boxCollider2d;
    [SerializeField] public LayerMask groundLayerMask;
    Rigidbody2D rb;

    public GameObject groundRayObect;
    private void Update()
    {
        //Aqui crido la funcio de cuan
        IsGrounded();
    }
    private bool IsGrounded()
    {
        RaycastHit2D hitGround = Physics2D.Raycast (groundRayObect.transform.position, -Vector2.up, groundLayerMask);
        Color rayColor;
        if (hitGround.collider != null)
        {
            rayColor = Color.green;
        }
        else
        {
            rayColor = Color.red;
        }


        /*
        float HeightText = .01f;
        RaycastHit2D raycastHit = Physics2D.Raycast(boxCollider2d.bounds.center, Vector2.down, boxCollider2d.bounds.extents.y + HeightText, groundLayerMask);
        Color rayColor;
        if (raycastHit.collider != null)
        {
            rayColor = Color.green;
        }else
        {
            rayColor = Color.red;
        }
        Debug.DrawRay(boxCollider2d.bounds.center, Vector2.down * (boxCollider2d.bounds.extents.y + HeightText) , rayColor);
        Debug.Log(raycastHit.collider);
        */
        Debug.DrawRay(groundRayObect.transform.position, -Vector2.up * hitGround.distance);
        Debug.Log(hitGround.collider);
        return hitGround.collider != null;
       
    }

}
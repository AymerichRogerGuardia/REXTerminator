using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorGround : MonoBehaviour
{
    public bool grounded;
   
    private void OnTriggerStay2D(Collider2D collision)
    {
        grounded = true;
    }

}
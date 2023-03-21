using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerShot : MonoBehaviour
{
    public float speed = 5f;
    public Transform fireStarts;
    public GameObject bulletPrefab;
    public Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.S))
        {
            //Animator.SetBool("Ishooting", true);
            Shoot();
        }
      
    }
    void Shoot()
    {
        Instantiate(bulletPrefab , fireStarts.position, fireStarts.rotation);
        animator.SetTrigger("Shoot");
    }
   
}

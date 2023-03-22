using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int healthplayer;
    public int currentHealthplayer;
    void Start()
    {
        currentHealthplayer = healthplayer;
    }


    void Update()
    {
        if (currentHealthplayer <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void damagePlayer(int damage)
    {
        currentHealthplayer -= damage;
    }
}


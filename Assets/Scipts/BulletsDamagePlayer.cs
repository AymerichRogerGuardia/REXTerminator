using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsDamagePlayer : MonoBehaviour
{
    public int bulletDamage;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerHealth>().damagePlayer(bulletDamage);
            Destroy(gameObject);
        }

    }
}

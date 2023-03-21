using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int lifes;
    public GameObject Target;
    public float speed;

    private float distance;

    private SpriteRenderer spriteRenderer;

    private float currTimeFire;
    public float TimeBurning;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Target != null)
        {
            Vector2 direction = Target.transform.position - transform.position;
            transform.position = Vector2.MoveTowards(transform.position, Target.transform.position, speed * Time.deltaTime);

            if (direction.x > 0)
            {
                spriteRenderer.flipX = false;
            }
            else if (direction.x < 0)
            {
                spriteRenderer.flipX = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyTarget")
        {
            Target = collision.gameObject;

        }
    }
    public void Bullet()
    {
        lifes--;
        if (lifes == 0)
        {
            Destroy(gameObject);
        }
    }

    public void FireBall()
    {
        currTimeFire += Time.deltaTime;
        if (currTimeFire >= TimeBurning)
        {
            lifes--;
        }

    }

}

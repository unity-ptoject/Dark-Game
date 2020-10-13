using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_bullets : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int enemy_dead = 3;
    void Start()
    {
        rb.velocity = transform.right * speed ;
    }

    ///// killer enemey

    void OnTriggerEnter2D(Collider2D other) 
    {

        if (other.gameObject.tag == "enemy") 
        {
            if(enemy_dead > 0)
            {
                enemy_dead--;
                Destroy(other.gameObject);
                Debug.Log(" u killer enemy");
            }

        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_bullets : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int enemy_health = 0;
    void Start()
    {
        rb.velocity = transform.right * speed ;
    }

    ///// killer enemey

    void OnTriggerEnter2D(Collider2D other) 
    {

        if (other.gameObject.tag == "enemy") 
        {
            Destroy(gameObject);
           // Destroy(other.gameObject);
             enemy_health++;
           Debug.Log("enemy dead : " +  enemy_health);
        }
    }

}

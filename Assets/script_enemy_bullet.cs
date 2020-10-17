using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_enemy_bullet : MonoBehaviour
{
    public float speed = 6f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed ;
    }

    ///// killer enemey

    void OnTriggerEnter2D(Collider2D other) 
    {

        if (other.gameObject.tag == "player")                  ///// if bulllets touch player will be distroy
        {
            Destroy(gameObject);
            Debug.Log("i touched player");

        }
    }

    public float timeRemaining = 2;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;  ////// timer counterdownd
            //Debug.Log("itimer : " + timeRemaining); 
        }
        if (timeRemaining <= 0)                  ///// if timer == 0  the bullets will be destroy
        {
             Destroy(gameObject);                  
           // Debug.Log("bullet is distroy withot touch player");
        }
    }
}

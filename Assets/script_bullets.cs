using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_bullets : MonoBehaviour
{
    public float speed = 11f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed ;
    }

    ///// killer enemey

    void OnTriggerEnter2D(Collider2D other) 
    {

        if (other.gameObject.tag == "enemy")                  ///// if bulllets touch enemy bullet will be distroy
        {
            Destroy(gameObject);
            Debug.Log("i tocuched enemy");

        }
    }

    public float timeRemaining = 1;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;  ////// timer counterdownd
            Debug.Log("itimer : " + timeRemaining); 
        }
        if (timeRemaining <= 0)                  ///// if timer == 0  the bullets will be destroy
        {
             Destroy(gameObject);                  
            Debug.Log("bullet is distroy withot touch enenmy");
        }
    }
}

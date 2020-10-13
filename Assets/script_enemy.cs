using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_enemy : MonoBehaviour
{
    public int health_enemy = 3;


    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) 
    {

        if (other.gameObject.tag == "bullet") 
        {
            if(health_enemy >0)
            {
                health_enemy--;
                //Destroy(gameObject);
                Debug.Log("enemy dead " + health_enemy );
            }
            if(health_enemy == 0)
            {
                Destroy(gameObject);
                Debug.Log("sd9aaaat rak mqaawd");
            }
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_enemy : MonoBehaviour
{
    public int health_enemy = 3;
    public GameObject slider_health_2;
    public GameObject slider_health_3;


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
                slider_health_2.SetActive(true);

                    if(health_enemy == 1)
                    {
                        Debug.Log("enemy dead " + health_enemy );
                        slider_health_3.SetActive(true);  
                        slider_health_2.SetActive(false);
                    }        
            }
            if(health_enemy == 0)
            {
                Destroy(gameObject);
                Debug.Log("sd9aaaat rak mqaawd");
            }
        }
    }

}

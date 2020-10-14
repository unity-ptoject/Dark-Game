using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class script_enemy : MonoBehaviour
{
    private Animator anime;
    public int health_enemy = 3;
    public float timeRemaining = 0.5f;
    public GameObject slider_health_1;
    public GameObject slider_health_2;
    public GameObject slider_health_3;



   void Start()
    {
       anime = GetComponent<Animator>();
    }
    void Update()
    {           
         if(health_enemy == 0)
         {
                if (timeRemaining > 0)
                {
                    timeRemaining -= Time.deltaTime;  ////// timer counterdownd
                    Debug.Log("itimer : " + timeRemaining); 
                }
                if (timeRemaining <= 0)                  ///// if timer == 0  the bullets will be destroy
                {
                    Destroy(gameObject);                  
                    Debug.Log("db ikhtafaaaaa");
                }
         }
    }
    void OnTriggerEnter2D(Collider2D other) 
    {

        if (other.gameObject.tag == "bullet") 
        {
            if(health_enemy >0)
            {
                health_enemy--;

                if(health_enemy == 2)
                {
                    //health_enemy--;
                    Debug.Log("enemy dead " + health_enemy );
                    slider_health_2.SetActive(true);
                    slider_health_1.SetActive(false);
                }

                if(health_enemy == 1)
                {
                    Debug.Log("enemy dead " + health_enemy );
                    slider_health_3.SetActive(true);  
                    slider_health_2.SetActive(false);
                    //slider_health_1.SetActive(false);
                }        
            }
            if(health_enemy == 0)
            {
                anime.Play("enemy_death"); 
                Debug.Log("sd9aaaat rak mqaawd");
                //Destroy(gameObject);
            }
        }
    }

}

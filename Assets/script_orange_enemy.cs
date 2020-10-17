using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class script_orange_enemy : MonoBehaviour
{
  
     private Animator anime;
    public int health_enemy = 3; //// health slider bar dyl enemy
    public float timing_death_enemy = 0.3f; /// dk le temp lighybqa dk lghobar dyalo apres madrb b bullet 3
    public GameObject slider_health_1;
    public GameObject slider_health_2;
    public GameObject slider_health_3;
    public Transform enemy_shot;
    public GameObject enemy_bullet;
    public float speed = 0.5f;
    public bool left ;
    public bool move;
    public bool shot = true;
    public float timing_shot = 0f;

   void Start()
    {
       anime = GetComponent<Animator>();
    }
    void Update()
    {    
        move_enemy();
        timing_enemy_shot();
        ///// conter time of killer enemy       
         if(health_enemy == 0)
         {
             shot = false;
             move = false;
                if (timing_death_enemy > 0)
                {
                    timing_death_enemy -= Time.deltaTime;  ////// timer counterdownd
                    Debug.Log("itimer : " + timing_death_enemy); 
                }
                if (timing_death_enemy <= 0)                  ///// if timer == 0  the enenmy will be destroy
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
                //Destroy(gameObject);
            }
        }
  
       if (other.gameObject.tag == "flowers") 
            {
                if(left)
                {
                    left = false;
                }
                else{
                    left = true;
                }
            }

    }

    void move_enemy(){
        if(move){
            if(left){
                anime.Play("rediswalk"); 
                transform.position += (Vector3.left * speed * Time.deltaTime); //// for running left
                //transform.Translate(2 * Time.deltaTime * speed , 0,0); //// hadu katmshu biha left
                //transform.localScale = new Vector2(.5f,.5f);  ///// hadu kadir lek retation mn scale ms saraha mfhmthach mzyaan 
                transform.eulerAngles = new Vector3 (0, -180 ,0); 
            }
            else{
                anime.Play("rediswalk"); 
                transform.position -= (Vector3.left * speed * Time.deltaTime);   //// for running left
                //transform.Translate(-2 * Time.deltaTime * speed , 0,0);  ///// hadu katmshu biha right
            //transform.localScale = new Vector2(-.5f,.5f);       ///// hadu kadir lek retation mn scale ms saraha mfhmthach mzyaan 
                transform.eulerAngles = new Vector3 (0 , 0 ,0);
            }
            //shot = false;
        }
        }
        
         void bullet_tire()
        {
          Instantiate(enemy_bullet , enemy_shot.position,enemy_shot.rotation); //// script bullet_enemy   
        }
   void timing_enemy_shot(){
            timing_shot += Time.deltaTime;  ////// timer counterdownd
           // Debug.Log("timer_shot : " + timing_shot); 

           if(timing_shot > 1f)
            {
                if(shot){
                    anime.Play("redisatack"); 
                    move = false;
                        if(timing_shot > 1.400f && timing_shot < 1.409f )
                        {
                            bullet_tire();
                        }
                        if(timing_shot > 1.500f && timing_shot < 1.509f )
                        {
                            bullet_tire();
                        }
                        if(timing_shot > 1.600f && timing_shot < 1.609f )
                        {
                            bullet_tire();
                        }
                }
            }
            if(timing_shot > 2f)
            {
                move = true;
                timing_shot = 0;
             }
             
        }
}

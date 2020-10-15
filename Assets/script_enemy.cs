﻿using System.Collections;
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
    public float timing_death_enemy = 0.2f;
    public GameObject slider_health_1;
    public GameObject slider_health_2;
    public GameObject slider_health_3;
    public Transform enemy_shot;
    public GameObject enemy_bullet;

   void Start()
    {
       anime = GetComponent<Animator>();
    }
    void Update()
    {    
        shot_enemy();
        move_enemy();
        ///// conter time of killer enemy       
         if(health_enemy == 0)
         {
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

    public float speed = 0.5f;

    public bool left ;
    void move_enemy(){

        if(left){
            transform.Translate(2 * Time.deltaTime * speed , 0,0); //// hadu katmshu biha left
            transform.localScale = new Vector2(.5f,.5f);  ///// hadu kadir lek retation mn scale ms saraha mfhmthach mzyaan 
          }
        else{
            transform.Translate(-2 * Time.deltaTime * speed , 0,0);  ///// hadu katmshu biha right
           transform.localScale = new Vector2(-.5f,.5f);       ///// hadu kadir lek retation mn scale ms saraha mfhmthach mzyaan 
           }
        }



    void shot_enemy(){
        if (Input.GetKeyUp(KeyCode.N))
        {
            Instantiate(enemy_bullet , enemy_shot.position,enemy_shot.rotation); //// hna aykhdem script dyl bullet_enemy witla9 l9rtaas
        }

    }







}

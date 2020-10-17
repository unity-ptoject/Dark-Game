using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class script_player : MonoBehaviour
{

    //// declaration des variable movement

            public int moveSpeed = 2;
            public float jumpHeight = 5.2f;
            private Animator anime;
            private bool isjumping = true;
            private bool faceLeft = true;
            public Transform fire_shot;
            public GameObject bullet;
            public float timing_death_player = 0.7f;  //timing will be player death 
    void Start()
    {
       anime = GetComponent<Animator>();
    }

    void Update()
    {
            run_left();
            run_right();
            jump_player();
            shot_player();
        if(health_player == 0)
         {
                if (timing_death_player > 0)
                {
                    timing_death_player -= Time.deltaTime;  ////// timer counterdownd
                    Debug.Log("itimer : " + timing_death_player); 
                }
                if (timing_death_player <= 0)                  ///// if timer == 0  the enenmy will be destroy
                {
                    Destroy(gameObject);                  
                    Debug.Log("db ikhtafaaaaa");
                }
         }
    }


    //////////////////////////////////////// run left function

    void run_left()
    {
            if (Input.GetKey(KeyCode.LeftArrow)) /// if u wlick leftarrow
            {
                transform.position += (Vector3.left * moveSpeed * Time.deltaTime); //// for running left

                if (faceLeft == true)  /// ila kan true ghychoof 9daamoo witmcha donc ghadu ikhdm function dyl flip
                {
                    flip();
                    faceLeft = false;
                }
            }
                    if (Input.GetKeyDown(KeyCode.LeftArrow)) /// if u down left arrow
                    {
                        Debug.Log("jra");
                        anime.Play("isrun"); 
                    // anime.SetBool("isrun", isrun);  /// for animation running if keydown
                    // isrun = false;
                    }
     
            if (Input.GetKeyUp(KeyCode.LeftArrow))  // if u up left arrow
            {
                Debug.Log("wqeeef");
                //anime.Stop("isrun"); 
                anime.Play("isidle"); 
             //  anime.SetBool("isrun", isrun);   /// for animation no running if keyup
               // isrun = true;
                //anime.SetBool("isidle", isidle);   /// for animation no running if keyup
            }
        
    }


    ///////////////////////////////////////// run right function


    void run_right()
    {
        if (Input.GetKey(KeyCode.RightArrow))  // if u click right arrow
        {
            transform.position -= (Vector3.left * moveSpeed * Time.deltaTime);   //// for running left

            
            if (faceLeft == false) /// ila kan false ghychoof moraah witmcha donc ghadu ikhdm function dyl flip wi bdel rotation dyalo
            {
                flip();
                faceLeft = true;
            }
            
        }
        
        
        if (Input.GetKeyDown(KeyCode.RightArrow))  ///if u down right arrow
        {
            // Debug.Log("jra");
           // anime.SetBool("isrun", isrun);   /// for animation running if keydown
            //isrun = false;
           anime.Play("isrun"); 
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))  /// if u up right arrow
        {
            //Debug.Log("wqeeef");
           // anime.SetBool("isrun", isrun);     /// for animation no running if keyup
            //isrun = true;
            //isrun = true;
            anime.Play("isidle"); 
        }
        
    }


    ///////////////////////////////////// jump function

    void jump_player()
    {

      if (Input.GetKey(KeyCode.Space))  /// if u click space arrow
        {

                transform.position += (Vector3.up * jumpHeight * Time.deltaTime);   //// for jumping
        }
        
        if (Input.GetKeyDown(KeyCode.Space))    /// if u down space arrow
        {
            // Debug.Log("n9eez");
           anime.SetBool("isjumping", isjumping);  //// for animation jumping
            isjumping = false;
           // jumpsound.SetActive(true);


        }

        if (Input.GetKeyUp(KeyCode.Space))  // if u up space arrow
        {
            //  Debug.Log("hbeeet");
            anime.SetBool("isjumping", isjumping);   //// for animation non jumping
            isjumping = true;
           // jumpsound.SetActive(false);
            
        }
        
    }


    //////////////////////////////////////// Shot function


    void shot_player(){
        if (Input.GetKeyUp(KeyCode.B))
        {
            Instantiate(bullet , fire_shot.position,fire_shot.rotation); //// hna aykhdem script dyl bullet witla9 l9rtaas
        }

    }

    //////////////////////////////////// Flip function

      void flip()
    {
        faceLeft = !faceLeft;  // if true he will be false      and      if false he will be true

        transform.Rotate(0f, 180f, 0);  /// this function will change the rotation to 180f if click in left arrow or right arrow
    }

    public int health_player = 3;
    
    public GameObject player_health_1;
    public GameObject player_health_2;
    public GameObject player_health_3;
        void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "obstacl")
           {
                Debug.Log(" 9aast obstaacl"); 
                anime.Play("isdeath"); 
                 Debug.Log("enemy dead " + health_player );
                player_health_3.SetActive(true);  
                   player_health_2.SetActive(false);
                     player_health_1.SetActive(false);
                health_player = 0;
           } 
        
        if (other.gameObject.tag == "bullet_enemy") 
        {
            Destroy(other.gameObject);
            if(health_player > 0)
            {
                health_player--;

                if(health_player == 2)
                {
                    Debug.Log("enemy dead " + health_player );

                    player_health_2.SetActive(true);
                    player_health_1.SetActive(false);
                }

                if(health_player == 1)
                {
                    Debug.Log("enemy dead " + health_player );
                    player_health_3.SetActive(true);  
                    player_health_2.SetActive(false);
                     player_health_1.SetActive(false);
                }        
            }
            if(health_player == 0)
            {
                anime.Play("isdeath"); 
                //Destroy(gameObject);
            }
        }
    }
}

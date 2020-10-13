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
            public int jumpHeight = 5;
            private Animator anime;
            private bool isjumping = true;
            private bool faceLeft = true;
            public Transform fire_shot;
            public GameObject bullet;
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
            Instantiate(bullet , fire_shot.position,fire_shot.rotation);
        }

    }

    //////////////////////////////////// Flip function

      void flip()
    {
        faceLeft = !faceLeft;  // if true he will be false      and      if false he will be true

        transform.Rotate(0f, 180f, 0);  /// this function will change the rotation to 180f if click in left arrow or right arrow
    }
}

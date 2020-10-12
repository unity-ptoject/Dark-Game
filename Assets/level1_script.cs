using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class level1_script : MonoBehaviour
{
    //public menu_script menu_Script;
    void start(){
        //GameObject thePlayer = GameObject.Find("ThePlayer");
        //menu_script menu_Script = thePlayer.GetComponent<menu_script>();
        //menu_Script.scoor = 10;
    }
public void back_to_menu()
{
SceneManager.LoadScene("menu"); //// teeeeeeeeeeeeeest
}


///// counter coins 
    //public int scoor = 0;
    public TextMeshProUGUI totalcoin_level1;
    
     //public int scoor_2 = 0;
    public void score_level1(){
           // GameObject thePlayer = GameObject.Find("ThePlayer");
            //menu_script menu_Script = thePlayer.GetComponent<menu_script>();
            //menu_Script.scoor = 10;
            //scoor_2 =+ menu_Script.scoor;
           // int test = menu_Script.scoor;
            //int scoor_level1 = menu_Script.scoor;
            //menu_Script.scoor;
            //totalcoin_level1.text = scoor_level1.ToString();
            Debug.Log("scoor : " + scoor_2);
            //scoor_level1++;
           // Debug.Log("is woorkiing");
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class level1_script : menu_script
{
    //public menu_script menu_Script;
    void start(){

    }
public void back_to_menu()
{
SceneManager.LoadScene("menu"); //// teeeeeeeeeeeeeest
}


///// counter coins 
    public TextMeshProUGUI totalcoin_level1;
    
    public void score_level1(){
            Debug.Log("scoor :" + scoor);
           // scoor++;

    }
}

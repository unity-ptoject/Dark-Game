using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class script_level_1 : script_menu
{
    public static bool game_is_pause = false;
    public GameObject Pause_UI;
    public GameObject counter_start;

private void Start() {
    Time.timeScale = 0f;
}
private void Update() {
    down_start();
}


public void back_to_menu()
{
SceneManager.LoadScene("menu"); //// teeeeeeeeeeeeeest
}


public void ads_button(){
    Time.timeScale = 0f;
}
public void pause_button(){
    Pause_UI.SetActive(true);
    Time.timeScale = 0f;
    game_is_pause = true;
}
public void resume_button(){
    Pause_UI.SetActive(false);
    Time.timeScale = 1f;
    game_is_pause = false;
}




    public float timing_counter = 0f;  //timing will be player death 
    public bool timing_321 = false;


   public void down_start(){
       if(timing_321){
        timing_counter += Time.deltaTime;  ////// timer counterdownd
        Debug.Log("timer_shot : " + timing_counter);   
        counter_start.SetActive(true);
       }
      if(timing_counter >  0.004f){
            Time.timeScale = 1f;
            counter_start.SetActive(false);
            timing_counter = 0f;
            timing_321 = false;
       }
    }


    public void timing_to_start(){
        Time.timeScale = 0.001f;
       timing_321 = true;
        //start_game.SetActive(false);
    }



/* counter coins 
    public TextMeshProUGUI totalcoin_level1;
    
    public void score_level_1(){
        totalcoin_level1.text = total.ToString();
        Debug.Log("scoor :" + total);
        total++;
    }
*/
}

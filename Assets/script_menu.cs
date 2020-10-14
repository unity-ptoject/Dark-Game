using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class script_menu : MonoBehaviour
{
/////////////////// buttons

public void playgame()
{
SceneManager.LoadScene("level1"); //// for go to the level1
}
public void exitgame(){
}


    public TextMeshProUGUI totalcoin_menu;
    public static int scoore = 0;
    public void score_game(){
        Debug.Log("scoor :" + scoore);
        totalcoin_menu.text = scoore.ToString(); /// score menu
    }
    public int total = scoore; /// all score in menu

}

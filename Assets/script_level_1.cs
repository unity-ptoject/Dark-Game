using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class script_level_1 : script_menu
{

  /*  private void Update() {
        totalcoin_level1.text = total.ToString();
    }
*/
public void back_to_menu()
{
SceneManager.LoadScene("menu"); //// teeeeeeeeeeeeeest
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

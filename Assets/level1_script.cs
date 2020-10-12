using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class level1_script : MonoBehaviour
{

    public menu_script menu_Script;

// Start is called before the first frame update
void Start()
{

}

// Update is called once per frame
void Update()
{
}
public void back_to_menu()
{
SceneManager.LoadScene("menu"); //// teeeeeeeeeeeeeest
menu_Script.test_call();
}


///// counter coins 
    //public int scoor = 0;
    public TextMeshProUGUI totalcoin_level1;
    public void score_level1(){
            int scoor_level1 = menu_Script.scoor;
            //totalcoin_level1.text = scoor_level1.ToString();
            //Debug.Log("scoor : " + scoor_level1);
            //scoor_level1++;
            Debug.Log("is noot working");
    }
}

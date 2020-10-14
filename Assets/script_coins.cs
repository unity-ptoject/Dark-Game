using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class script_coins : script_menu
{
    public TextMeshProUGUI totalcoin_level1;

    private void Start() {
        totalcoin_level1.text = total.ToString();
    }
    private void Update() {
    }

///// counter coins 
         void OnTriggerEnter2D(Collider2D other)  // hadu zid qra 3liha mzyaaan mfhmthach mzyan 
        {
            // ///////////  coins script
            if (other.gameObject.tag == "coins")  // hna katgolih if player touch coins
            {
                total++;
                Debug.Log("scoor : " + total);
                Destroy(other.gameObject); /// hdu katmssh lik dk object dyl coins
                totalcoin_level1.text = total.ToString();
            }
        }
    
}
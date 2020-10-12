using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class menu_script : MonoBehaviour
{
// Start is called before the first frame update
void Start()
{

}

// Update is called once per frame
void Update()
{

}

/////////////////// buttons

public void playgame()
{
SceneManager.LoadScene("level1"); //// for go to the level1
}
public void exitgame(){
score_game(); ////////////////// TEEEEEEEEEEEEST
}

///////////////////////////score the game 

public int scoor = 10;
public TextMeshProUGUI totalcoin;
public void score_game(){
    scoor++;
    Debug.Log("scoor : " + scoor);
    totalcoin.text = scoor.ToString();
}
}

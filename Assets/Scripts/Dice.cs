using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dice : MonoBehaviour
{
    
    public TMP_Text Score;
    public TMP_Text highScore;

private void Start() {
    highScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
}
    public void RollDice(){
        int number = Random.Range(1,7); //1 inclusive, 7 exclusive
        Score.text = number.ToString(); //as text are strings in editor

        if(number > PlayerPrefs.GetInt("HighScore",0)){
            PlayerPrefs.SetInt("HighScore", number);
            highScore.text = number.ToString();
        }

        
    }

    public void ResetScore(){
        PlayerPrefs.DeleteAll();
        highScore.text = "0";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 30;
    public Text textoTimer;

    private void Update()
    {    
        textoTimer.text = "" + timeRemaining.ToString("f0");

        PlayerPrefs.SetFloat("tResto", timeRemaining);

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else {
            //Debug.Log("Game Over  Timer");
            Juego.gameOver = true;
        }

        //Debug.Log(timeRemaining);

    }


}

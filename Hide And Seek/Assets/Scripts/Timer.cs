using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 30;

    private void Update()
    {
        timeRemaining -= Time.deltaTime;

        if (timeRemaining > 0)
        {
            Debug.Log(timeRemaining);
        }
        else {
            Debug.Log("Game Over");
            
            //Menu para reiniciar
        }
    }


}

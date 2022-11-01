using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject enemigos, pGameOver;
    public PlayerControler movimiento;
    public CamaraMove camara;
    public Timer pausaTiempo;

    // Update is called once per frame
    void Update()
    {
        if (Juego.gameOver == true)
        {
            Cursor.lockState = CursorLockMode.None;

            enemigos.SetActive(false);
            movimiento.enabled = false;
            camara.enabled = false;
            pGameOver.SetActive(true);
            pausaTiempo.enabled = false;
        }
        else if(Juego.gameOver == false)
        {
            //enemigos.SetActive(true);
            //movimiento.enabled = true;
            //camara.enabled = true;
            //pGameOver.SetActive(false);
        }
        
    }
}

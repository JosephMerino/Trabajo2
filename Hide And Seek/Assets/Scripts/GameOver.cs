using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject enemigos, pGameOver;
    public PlayerControler movimiento;
    public CamaraMove camara;
    public Timer pausaTiempo;
    public Pausa pausaJuego;

    // Update is called once per frame
    void Update()
    {
        if (Juego.gameOver == true)
        {
            enemigos.SetActive(false);
            movimiento.enabled = false;
            camara.enabled = false;
            pausaJuego.enabled = false;
            pGameOver.SetActive(true);
            pausaTiempo.enabled = false;

            Cursor.lockState = CursorLockMode.None;
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

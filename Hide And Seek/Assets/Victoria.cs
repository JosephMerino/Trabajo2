using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victoria : MonoBehaviour
{
    public GameObject enemigos, pVictoria;
    public PlayerControler movimiento;
    public CamaraMove camara;
    public Timer pausaTiempo;

    // Update is called once per frame
    void Update()
    {
        if (Juego.victoria == true)
        {
            Cursor.lockState = CursorLockMode.None;

            enemigos.SetActive(false);
            movimiento.enabled = false;
            camara.enabled = false;
            pVictoria.SetActive(true);
            pausaTiempo.enabled = false;
        }
        else
        {
            //enemigos.SetActive(true);
            //movimiento.enabled = true;
            //camara.enabled = true;
            //pGameOver.SetActive(false);
        }

    }
}

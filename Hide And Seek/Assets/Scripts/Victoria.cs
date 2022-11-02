using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victoria : MonoBehaviour
{
    public GameObject enemigos, pVictoria;
    public PlayerControler movimiento;
    public CamaraMove camara;
    public Timer pausaTiempo;
    public Pausa pausaJuego;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Juego.victoria == true)
        {
            movimiento.enabled = false;
            camara.enabled = false;
            pausaJuego.enabled = false;
            pausaTiempo.enabled = false;
            pVictoria.SetActive(true);
            enemigos.SetActive(false);

            Cursor.lockState = CursorLockMode.None;
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

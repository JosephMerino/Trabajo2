using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    public GameObject pJuego, pPausa , enemigos, disparo;
    public PlayerControler movimiento;
    public CamaraMove camara;
    public Timer pausaTiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Juego.pausa == true)
        {
            Cursor.lockState = CursorLockMode.None;

            pJuego.SetActive(false);
            disparo.SetActive(false);
            enemigos.SetActive(false);
            movimiento.enabled = false;
            camara.enabled = false;
            pausaTiempo.enabled = false;
            pPausa.SetActive(true);
        }
        else if (Juego.pausa == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
            pJuego.SetActive(true);
            disparo.SetActive(true);
            enemigos.SetActive(true);
            movimiento.enabled = true;
            camara.enabled = true;
            pausaTiempo.enabled = true;
            pPausa.SetActive(false);
        }

    }
}

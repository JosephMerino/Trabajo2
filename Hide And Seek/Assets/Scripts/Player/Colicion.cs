using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colicion : MonoBehaviour
{
    public static float vidas;
    private bool timeOut;
    public Text cVidas;

    // Start is called before the first frame update
    void Start()
    {
        timeOut = true;
        cVidas.text = "Vidas : " + vidas.ToString("f0");
    }
    private void FixedUpdate()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (timeOut == true)
        {
            timeOut = false;

            if (collision.gameObject.CompareTag("Player"))
            {
                //Debug.Log("Golpe contra el player  " + vidas);
                vidas = vidas - 1;
                cVidas.text = "Vidas : " + vidas.ToString("f0");
                
                if (vidas <= 0)
                {
                    //Debug.Log("GameOver Colisiones");
                    Juego.gameOver = true;
                }
            }
            StartCoroutine(descVidas());
        }
        else {
            //Debug.Log("TimeOut");
        }        
    }

    IEnumerator descVidas() 
    {        
        yield return new WaitForSeconds(2f);

        timeOut = true;
    }

}

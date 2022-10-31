using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colicion : MonoBehaviour
{
    public static int vidas;
    private bool timeOut;

    // Start is called before the first frame update
    void Start()
    {
        timeOut = true;        
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

                if (vidas == 0)
                {
                    Debug.Log("GameOver");
                    //Muenu para reiniciar
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
        yield return new WaitForSeconds(3f);

        timeOut = true;
    }

}

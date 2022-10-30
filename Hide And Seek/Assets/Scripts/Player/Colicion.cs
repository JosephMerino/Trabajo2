using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colicion : MonoBehaviour
{
    public static float vidas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            vidas -= 1;
            //Debug.Log("Golpe contra el player");

            if (vidas <1)
            {
                //Debug.Log("GameOver");
                
                //Muenu para reiniciar
            }
        }
    }

}

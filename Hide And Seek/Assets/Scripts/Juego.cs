using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juego : MonoBehaviour
{
    public int dificultad;

    private void Awake()
    {
        if (dificultad == 1)
        {
            Colicion.vidas = 5;
        }
        else if (dificultad == 2)
        {
            Colicion.vidas = 3;
        }
        else if (dificultad == 3)
        {
            Colicion.vidas = 1;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

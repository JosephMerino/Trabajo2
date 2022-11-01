using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juego : MonoBehaviour
{
    public int vidas;
    public static bool gameOver , victoria ,pausa;

    private void Awake()
    {
        gameOver = false;
        victoria = false;
        pausa = false;

        Colicion.vidas = vidas;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Despausar()
    {
        pausa = false;
    }
}

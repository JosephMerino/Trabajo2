using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    public Text tiempoPuntuacion;

    public 
    // Start is called before the first frame update
    void Start()
    {              
    }

    // Update is called once per frame
    void Update()
    {
        tiempoPuntuacion.text = "Completado en " + PlayerPrefs.GetFloat("tResto").ToString("f0") + " segundos";
        //Debug.Log(tiempoCompletado);
    }
}

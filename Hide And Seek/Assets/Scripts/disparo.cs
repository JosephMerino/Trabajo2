using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    public Rigidbody proyectil;
    public Transform cañon;
    private AudioSource SonidoBala;

    void Start()
    {
        SonidoBala = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody instanciaProyectil;
            instanciaProyectil = Instantiate(proyectil, cañon.position, cañon.rotation) as Rigidbody;
            instanciaProyectil.AddForce(cañon.forward * 2500);
            SonidoBala.Play();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Juego.pausa = true;
        }

    }
}

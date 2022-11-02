using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoEnemigo : MonoBehaviour
{
    public AudioSource Emite;
    public AudioClip SonidoMuerte;

    private void OnTriggerEnter(Collider other)
    {
        Emite.PlayOneShot(SonidoMuerte);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    public Rigidbody proyectil;
    public Transform cañon;
    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody instanciaProyectil;
            instanciaProyectil = Instantiate(proyectil, cañon.position, cañon.rotation) as Rigidbody;
            instanciaProyectil.AddForce(cañon.forward * 2500);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    public Rigidbody proyectil;
    public Transform ca�on;
    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody instanciaProyectil;
            instanciaProyectil = Instantiate(proyectil, ca�on.position, ca�on.rotation) as Rigidbody;
            instanciaProyectil.AddForce(ca�on.forward * 2500);
        }

    }
}

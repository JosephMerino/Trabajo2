using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColicionBala : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1.5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Pared" || other.gameObject.name == "Piso")
        {
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Enemigo"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

    }
}

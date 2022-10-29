using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Vector2 sensibility;
    private Transform camara;

    // Start is called before the first frame update
    void Start()
    {
        camara = transform.Find("Main Camera");
       
        
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Mouse X");
        float ver = Input.GetAxis("Mouse Y");

        if (hor != 0)
        {
            transform.Rotate(Vector3.up * hor * sensibility.x);
        }

        if (ver != 0)
        {
            camara.Rotate(Vector3.left * hor * sensibility.x);
        }

    }
}

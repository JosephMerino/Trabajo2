using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiofuente : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(5);
        GetComponent<AudioSource>
    }

    
}

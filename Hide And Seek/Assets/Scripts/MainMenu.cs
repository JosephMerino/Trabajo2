using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public InputField inputNombre;
    private string nombre;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CargarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void Dificultad(int dificultad) {
        PlayerPrefs.SetInt("Dificultad", dificultad);

        //Debug.Log(dificultad);
    }
    public void Nombre()
    {
        nombre = inputNombre.text;
        PlayerPrefs.SetString("Nombre", nombre.ToUpper());

        //Debug.Log(nombre);
    }
}

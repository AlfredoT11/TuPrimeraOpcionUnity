using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComenzarTestTecnico : MonoBehaviour
{
    
    public Text nombre;
    public GameObject introduccion;
    public GameObject pregunta;
    public GameObject terminada;

    void leerNombre(){
        Debug.Log(nombre.text);
        introduccion.SetActive(false);
        pregunta.SetActive(true);
        List<object> paqueteDatos = new List<object>();
        paqueteDatos.Add(terminada);
        paqueteDatos.Add(nombre.text);
        pregunta.SendMessage("instanciarTerminar", paqueteDatos);

    }


    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => leerNombre());
        introduccion = GameObject.Find("Introduccion");
        pregunta = GameObject.Find("Pregunta");
        terminada = GameObject.Find("PruebaTerminada");
        pregunta.SetActive(false);
        terminada.SetActive(false);
    }

}

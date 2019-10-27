using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manejadorBotones : MonoBehaviour
{

    public GameObject pregunta;
    public static int contadorPreguntas;

    public void evaluacionRespuesta(){

        int []paqueteOpciones = new int[2];

        Debug.Log("Pregunta #"+contadorPreguntas);
        Debug.Log(this.gameObject.transform.GetChild(0).GetComponent<Text>().text[0]);

        
        paqueteOpciones[0] = contadorPreguntas;
        paqueteOpciones[1] = (int)char.GetNumericValue(this.gameObject.transform.GetChild(0).GetComponent<Text>().text[0]);
        //paqueteOpciones[1] = 1;

        GameObject.Find("Pregunta").SendMessage("cambiandoValor", paqueteOpciones);
        contadorPreguntas++;
    }


    void Start(){
        GetComponent<Button>().onClick.AddListener(() => evaluacionRespuesta());
        contadorPreguntas = 0;
    }

}
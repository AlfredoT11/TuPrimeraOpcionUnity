using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvaluacionRecibimiento : MonoBehaviour
{
    
    public void evaluacionRecibimiento(){
        
        string mensajeRecibimiento = this.gameObject.transform.GetChild(0).GetComponent<Text>().text[0].ToString();
        int puntuacion = 0;

        Debug.Log("Repeción de cliente: "+mensajeRecibimiento);

        switch(mensajeRecibimiento){
            case "1":
                puntuacion = 2;
            break;
            case "2":
                puntuacion = 3;
            break;
            case "3":
                puntuacion = 4;
            break;
            case "4":
                puntuacion = 5;
            break;
            case "5":
                puntuacion = 1;
            break;                                                
        }


        GameObject.Find("ControladorPrincipal").SendMessage("eleccionRecibimiento", puntuacion);
    }

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => evaluacionRecibimiento());
    }
}

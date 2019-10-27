using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvaluacionMedioTrabajo : MonoBehaviour
{
    
    private void evaluacionMT(){
        string medioSeleccionado = this.gameObject.transform.GetChild(0).GetComponent<Text>().text;
        Debug.Log("Medio seleccionado: "+medioSeleccionado);

        GameObject.Find("ControladorPrincipal").SendMessage("seleccionMT", medioSeleccionado);        
    } 

    void Start()
    {
         GetComponent<Button>().onClick.AddListener(() => evaluacionMT());       
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvaluacionPersonaje : MonoBehaviour
{

    public void evaluacionPersonaje(){
        string personajeSeleccionado = this.gameObject.transform.GetChild(0).GetComponent<Text>().text;
        Debug.Log("Personaje seleccionado: "+personajeSeleccionado);

        GameObject.Find("ControladorPrincipal").SendMessage("seleccionPersonaje", personajeSeleccionado);

    }

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => evaluacionPersonaje());
    }

}

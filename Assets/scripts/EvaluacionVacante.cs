using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvaluacionVacante : MonoBehaviour
{
    
    public void evaluacionVacanteElegida(){
        string vacanteElegida = this.gameObject.transform.GetChild(0).GetComponent<Text>().text;
        Debug.Log("Vacante elegida: "+vacanteElegida);

        GameObject.Find("ControladorPrincipal").SendMessage("eleccionVacante", vacanteElegida);
    }

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => evaluacionVacanteElegida());
    }

}

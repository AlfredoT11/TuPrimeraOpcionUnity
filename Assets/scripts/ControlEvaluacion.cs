using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControlEvaluacion : MonoBehaviour
{
    
    string personajeSeleccionado;
    string medioBusquedaTrabajo;
    string vacanteElegida;
    List<object> lista42;

    public void seleccionPersonaje(string personajeSeleccionado){
        Debug.Log("Personaje seleccionado: "+personajeSeleccionado);
        this.personajeSeleccionado = personajeSeleccionado;
    }

    public void seleccionMT(string medioSeleccionado){
        Debug.Log("Medio seleccionado: "+medioSeleccionado);
        this.medioBusquedaTrabajo = medioSeleccionado;

    }

    public void eleccionVacante(string vacanteElegida){
        Debug.Log("Vacante elegida: "+vacanteElegida);
        this.vacanteElegida = vacanteElegida;
    }

    public void eleccionRecibimiento(int puntuacion){
        int auxPuntuacion = (int)lista42[0] + puntuacion;
        lista42[0] = auxPuntuacion;
        lista42[1] = (int)lista42[1] + 1;

        Debug.Log("4.2 Puntuacion: "+lista42[0]+" Cantidad: "+lista42[1]);
    }

    void Start()
    {
    
        lista42 = new List<object>();
        lista42.Add(0); //Valor total.
        lista42.Add(0); //Cantidad.

    }
        
}

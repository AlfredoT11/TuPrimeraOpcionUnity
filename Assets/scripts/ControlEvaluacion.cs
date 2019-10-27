using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControlEvaluacion : MonoBehaviour
{
    
    string personajeSeleccionado;
    string medioBusquedaTrabajo;
    string vacanteElegida;

    List<GameObject> evaluaciones;

    //Responsabilidad
    List<object> lista12;
    List<object> lista14;

    //Manejo
    List<object> lista23;
    List<object> lista25;

    //Espíritu colaborativo

    //Comunicación para el impacto
    List<object> lista42;

    public void seleccionPersonaje(string personajeSeleccionado){
        Debug.Log("Personaje seleccionado: "+personajeSeleccionado);
        this.personajeSeleccionado = personajeSeleccionado;
        evaluaciones[0].SetActive(false);
        evaluaciones[1].SetActive(true);
    }

    public void seleccionMT(string medioSeleccionado){
        Debug.Log("Medio seleccionado: "+medioSeleccionado);
        this.medioBusquedaTrabajo = medioSeleccionado;
        evaluaciones[1].SetActive(false);
        evaluaciones[2].SetActive(true);

    }

    public void eleccionVacante(string vacanteElegida){
        Debug.Log("Vacante elegida: "+vacanteElegida);
        this.vacanteElegida = vacanteElegida;
        evaluaciones[2].SetActive(false);
        evaluaciones[3].SetActive(true);
    }

    public void eleccionRecibimiento(int puntuacion){
        int auxPuntuacion = (int)lista42[0] + puntuacion;
        lista42[0] = auxPuntuacion;
        lista42[1] = (int)lista42[1] + 1;

        Debug.Log("4.2 Puntuacion: "+lista42[0]+" Cantidad: "+lista42[1]);
        evaluaciones[3].SetActive(false);
        evaluaciones[4].SetActive(true);
    }

    public void eleccionClienteMolesto(List<int> valoresPonderados){
        int auxPuntuacion = (int)lista12[0] + valoresPonderados[0];
        lista12[0] = auxPuntuacion;
        lista12[1] = (int)lista12[1] + 1;

        auxPuntuacion = (int)lista14[0] + valoresPonderados[0];
        lista14[0] = auxPuntuacion;
        lista14[1] = (int)lista14[1] + 1; 

        auxPuntuacion = (int)lista23[0] + valoresPonderados[0];
        lista23[0] = auxPuntuacion;
        lista23[1] = (int)lista23[1] + 1; 

        auxPuntuacion = (int)lista25[0] + valoresPonderados[0];
        lista25[0] = auxPuntuacion;
        lista25[1] = (int)lista25[1] + 1;        

        auxPuntuacion = (int)lista42[0] + valoresPonderados[0];
        lista42[0] = auxPuntuacion;
        lista42[1] = (int)lista42[1] + 1;       

        Debug.Log("1.2 Puntuacion: "+lista12[0]+" Cantidad: "+lista12[1]);
        Debug.Log("1.3 Puntuacion: "+lista14[0]+" Cantidad: "+lista14[1]);
        Debug.Log("2.3 Puntuacion: "+lista23[0]+" Cantidad: "+lista23[1]);
        Debug.Log("2.5 Puntuacion: "+lista25[0]+" Cantidad: "+lista25[1]);
        Debug.Log("4.2 Puntuacion: "+lista42[0]+" Cantidad: "+lista42[1]);

        evaluaciones[4].SetActive(false);
        //evaluaciones[5].SetActive(true);
    }

    void Start()
    {

        evaluaciones = new List<GameObject>();
        evaluaciones.Add(GameObject.Find("Introduccion"));
        evaluaciones.Add(GameObject.Find("MedioTrabajo"));
        evaluaciones.Add(GameObject.Find("Trabajo"));
        evaluaciones.Add(GameObject.Find("RecibimientoCliente"));
        evaluaciones.Add(GameObject.Find("ClienteMolesto"));

        evaluaciones[1].SetActive(false);
        evaluaciones[2].SetActive(false);
        evaluaciones[3].SetActive(false);
        evaluaciones[4].SetActive(false);

        lista12 = new List<object>();
        lista12.Add(0); //Valor total.
        lista12.Add(0); //Cantidad.        

        lista14 = new List<object>();
        lista14.Add(0); //Valor total.
        lista14.Add(0); //Cantidad.

        lista23 = new List<object>();
        lista23.Add(0); //Valor total.
        lista23.Add(0); //Cantidad.

        lista25 = new List<object>();
        lista25.Add(0); //Valor total.
        lista25.Add(0); //Cantidad.

        lista42 = new List<object>();
        lista42.Add(0); //Valor total.
        lista42.Add(0); //Cantidad.

    }
        
}

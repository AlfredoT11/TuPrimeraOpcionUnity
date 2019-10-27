using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaquetePruebaTecnica : MonoBehaviour
{
    
    List<object> paqueteResultadosTecnicos;


    public void recibirInformacion(List<object> paquete){
        paqueteResultadosTecnicos = paquete;
        Debug.Log("MENSAJE FINAL RECIBIDO");
        Debug.Log("Nombre: "+paquete[0]+" MK: "+paquete[1]+" El:"+paquete[2]+" Me:"+paquete[3]+" Si: "+paquete[4]);
    }

    void Awake()
    {

        paqueteResultadosTecnicos = new List<object>();

        DontDestroyOnLoad(this.gameObject);
    }

}

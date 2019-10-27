using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespuestaTecnica 
{

    public int numeroPregunta;
    public double[,] ponderaciones;

    public RespuestaTecnica(int noPregunta, double[] ponderacionesArreglo){
        numeroPregunta = noPregunta;

        ponderaciones = new double[4,4];
        ponderaciones[0,0] = ponderacionesArreglo[0];
        ponderaciones[0,1] = ponderacionesArreglo[1];
        ponderaciones[0,2] = ponderacionesArreglo[2];
        ponderaciones[0,3] = ponderacionesArreglo[3];
        ponderaciones[1,0] = ponderacionesArreglo[4];
        ponderaciones[1,1] = ponderacionesArreglo[5];
        ponderaciones[1,2] = ponderacionesArreglo[6];
        ponderaciones[1,3] = ponderacionesArreglo[7];
        ponderaciones[2,0] = ponderacionesArreglo[8];
        ponderaciones[2,1] = ponderacionesArreglo[9];
        ponderaciones[2,2] = ponderacionesArreglo[10];
        ponderaciones[2,3] = ponderacionesArreglo[11];
        ponderaciones[3,0] = ponderacionesArreglo[12];
        ponderaciones[3,1] = ponderacionesArreglo[13];
        ponderaciones[3,2] = ponderacionesArreglo[14];
        ponderaciones[3,3] = ponderacionesArreglo[15];

    }

}

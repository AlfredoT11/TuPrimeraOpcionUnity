using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pregunta
{

    public string pregunta;
    public List<string> respuestas;
    //public List<string> areas;

    public Pregunta(string pregunta, List<string> respuestas /*List<string> areas*/){
        this.pregunta = pregunta;
        this.respuestas = respuestas;
        //this.areas = areas;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPreguntasTecnicas : MonoBehaviour
{
 
    public List<Pregunta> preguntas;
    public GameObject respuestaPrefab;
    private List<string> respuestas;
    private List<string> areas;
    private List<GameObject> objRespuestas;
    public Text textoPregunta;
    private List<string> preguntasS;
    private List<RespuestaTecnica> respuestasTecnicas;
    private double[] ponderacionesFinales;
    private string nombreUsuario;

    GameObject pruebaTerminada;

    public void cambiandoValor(int[] paqueteOpciones){ //Cambia a la siguiente pregunta.
        //Debug.Log("Recibiendo el mensaje.");
        textoPregunta.text = preguntasS[paqueteOpciones[0]]; //Numero de pregunta.
        aumentarPonderaciones(paqueteOpciones);

        Debug.Log("Preguntas: "+preguntasS.Count+" No. Pregunta"+paqueteOpciones[0]);

        if(preguntasS.Count - 1 <= paqueteOpciones[0]){
            Debug.Log("Preguntas terminadas.");

            Debug.Log("MK: " + ponderacionesFinales[0] + " El: "+ ponderacionesFinales[1] +" Me: "+ 
                        ponderacionesFinales[2] +" Si: "+ponderacionesFinales[3]);

            this.transform.gameObject.SetActive(false);
            pruebaTerminada.SetActive(true);

            List<object> paqueteFinal = new List<object>();
            paqueteFinal.Add(nombreUsuario);
            paqueteFinal.Add(ponderacionesFinales[0]);
            paqueteFinal.Add(ponderacionesFinales[1]);
            paqueteFinal.Add(ponderacionesFinales[2]);
            paqueteFinal.Add(ponderacionesFinales[3]);
            Debug.Log("MENSAJE FINAL ENVIADO");
            GameObject.Find("InformacionPruebaTecnica").SendMessage("recibirInformacion", paqueteFinal);


        }
        
    }

    private void aumentarPonderaciones(int[] paqueteOpciones){

        Debug.Log("Pregunta: "+paqueteOpciones[0]+" Opcion: "+paqueteOpciones[1]);

        Debug.Log(respuestasTecnicas[paqueteOpciones[0]].ponderaciones[paqueteOpciones[1]-1,0]);
        Debug.Log(respuestasTecnicas[paqueteOpciones[0]].ponderaciones[paqueteOpciones[1]-1,1]);
        Debug.Log(respuestasTecnicas[paqueteOpciones[0]].ponderaciones[paqueteOpciones[1]-1,2]);
        Debug.Log(respuestasTecnicas[paqueteOpciones[0]].ponderaciones[paqueteOpciones[1]-1,3]);

        ponderacionesFinales[0] += respuestasTecnicas[paqueteOpciones[0]].ponderaciones[paqueteOpciones[1]-1,0];
        ponderacionesFinales[1] += respuestasTecnicas[paqueteOpciones[0]].ponderaciones[paqueteOpciones[1]-1,1];
        ponderacionesFinales[2] += respuestasTecnicas[paqueteOpciones[0]].ponderaciones[paqueteOpciones[1]-1,2];
        ponderacionesFinales[3] += respuestasTecnicas[paqueteOpciones[0]].ponderaciones[paqueteOpciones[1]-1,3];

    }

    public void instanciarTerminar(List<object> paquete){
        Debug.Log("Nombre recibido: "+paquete[1]);
        pruebaTerminada = (GameObject)paquete[0];
        this.nombreUsuario = paquete[1].ToString();
    }

    void Start()
    {
        
        //pruebaTerminada = GameObject.Find("PruebaTerminada");
        //pruebaTerminada.SetActive(false);

        respuestasTecnicas = new List<RespuestaTecnica>();
        //MK, ME, EL, SI

        double []auxPonderaciones;
        auxPonderaciones = new double[16]{.5, 0,  0,  1, 0,  1,  0,  0, 0,  0,  0,  1, 0,  1,  0,  0};
        respuestasTecnicas.Add(new RespuestaTecnica(0, auxPonderaciones));
        auxPonderaciones = new double[16]{.5, 1, .25, 0, 0,  0,  0,  1, .5, 1, .25, 0, 0,  0,  0,  1};
        respuestasTecnicas.Add(new RespuestaTecnica(1, auxPonderaciones));
        auxPonderaciones = new double[16]{.5, 1,  0,  0, 0,  0,  .5, 1, .5, 1,  0,  0, 0,  0,  .5, 1};
        respuestasTecnicas.Add(new RespuestaTecnica(2, auxPonderaciones));
        auxPonderaciones = new double[16]{.5, 0,  0,  1, 0,  1,  .5, 0, 0,  0,  0,  1, 0,  1,  .5, 0};
        respuestasTecnicas.Add(new RespuestaTecnica(3, auxPonderaciones));
        auxPonderaciones = new double[16]{.5, 0,  1,  0, 0,  1,  0, .5, 0,  0,  1,  0, 0,  1,  0, .5};
        respuestasTecnicas.Add(new RespuestaTecnica(4, auxPonderaciones));
        auxPonderaciones = new double[16]{.5, 1,  0,  0, 0,  0, .5,  1, 0,  1,  0,  0, 0,  0, .5,  1};
        respuestasTecnicas.Add(new RespuestaTecnica(5, auxPonderaciones));
        auxPonderaciones = new double[16]{1, .5, .25, 0, 0,  0,  0,  1, 1, .5,  0,  0, 0,  0,  0,  1};
        respuestasTecnicas.Add(new RespuestaTecnica(6, auxPonderaciones));
        auxPonderaciones = new double[16]{1,  0, .5,  0, 0,  1,  0,  0, 1,  0,  0,  0, 0,  1,  0,  0};
        respuestasTecnicas.Add(new RespuestaTecnica(7, auxPonderaciones));
        auxPonderaciones = new double[16]{1,  0,  0,  0, 0,  0, .5,  1, 1,  0,  0,  0, 0,  0, .5,  1};
        respuestasTecnicas.Add(new RespuestaTecnica(8, auxPonderaciones));
        auxPonderaciones = new double[16]{0,  1,  0,  0, 0,  0, .5,  1, .5, 1,  0,  0, .5, 1,  0,  0};
        respuestasTecnicas.Add(new RespuestaTecnica(9, auxPonderaciones));        



        ponderacionesFinales = new double[4];
        ponderacionesFinales[0] = 0;
        ponderacionesFinales[1] = 0;
        ponderacionesFinales[2] = 0;
        ponderacionesFinales[3] = 0;

        objRespuestas = new List<GameObject>();

        preguntas = new List<Pregunta>();

        preguntasS = new List<string>();
        //preguntasS.Add("¿Sabes utilizar equipo de cómputo?");
        preguntasS.Add("¿Sabes usar herramientas?");
        preguntasS.Add("¿Te interesa el trabajo de diseño de piezas?");
        preguntasS.Add("¿Te interesa la programación?");
        preguntasS.Add("¿Quieres aprender temas de electricudad?");
        preguntasS.Add("¿Te gusta el diseño industrial?");
        preguntasS.Add("¿Te gusta armar o desarmar cosas?");
        preguntasS.Add("¿Te gusta la robótica?");
        preguntasS.Add("¿Te gustaría automatizar las cosas?");
        preguntasS.Add("¿Te interesa cómo se crean los objetos?");

        
/*         respuestas = new List<string>();
        respuestas.Add( "Campo");
        respuestas.Add( "Independiente");
        respuestas.Add( "Industria");
        respuestas.Add( "Negocio propio");
        
        valores = new List<string>();
         areas.Add("SIMK");
         areas.Add("ME");
         areas.Add("SI");
         areas.Add("ME"); */
        
        //preguntas.Add(new Pregunta("¿Dónde te gustaría trabajar?", respuestas, areas));

        respuestas = new List<string>();
        respuestas.Add( "1.-Sí.");
        respuestas.Add( "2.-No.");
        respuestas.Add( "3.-Aprendería.");
        respuestas.Add( "4.-No es de mi interés.");
        
        /*7areas = new List<string>();
        areas.Add("SIMK");
        areas.Add("ME");
        areas.Add("SI");
        areas.Add("ME");*/
        
        preguntas.Add(new Pregunta("¿Sabes utilizar equipo de cómputo?", respuestas/* , areas*/));
        
        /*areas = new List<string>();
        areas.Add("MEMKEL");
        areas.Add("SI");
        areas.Add("MEMKEL");
        areas.Add("SI");*/
        
        //preguntas.Add(new Pregunta("¿Sabes usar herramientas?", respuestas /*,areas*/));        
        
        Debug.Log(preguntas.Count);

        for(int i = 0; i<preguntas.Count; i++){
            Debug.Log(preguntas[i].pregunta + " " + string.Join(", ", preguntas[i].respuestas.ToArray()));
        }

        int auxPosY = -30;

        for(int i = 0; i<preguntas[0].respuestas.Count; i++){
            objRespuestas.Add(Instantiate(respuestaPrefab, new Vector3(0,0,0), Quaternion.identity) as GameObject);
            objRespuestas[i].transform.parent = GameObject.Find("Pregunta").transform;
            objRespuestas[i].GetComponent<RectTransform>().anchoredPosition = new Vector3(0 , auxPosY, 0);
            auxPosY -= 65;
        }

        textoPregunta.text = preguntas[0].pregunta;

        int j = 0;
        foreach(Transform child in transform){
            Debug.Log(child.transform.GetChild(0).name);
            child.transform.GetChild(0).GetComponent<Text>().text = preguntas[0].respuestas[j];
            j++;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


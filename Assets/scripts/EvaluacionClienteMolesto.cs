using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvaluacionClienteMolesto : MonoBehaviour
{
    
    public void evaluacionClienteMolesto(){
        List<int> valoresPonderados = new List<int>(); //1.2, 1.4, 2.3, 2.5, 4.2
        valoresPonderados.Add(0);
        valoresPonderados.Add(0);
        valoresPonderados.Add(0);
        valoresPonderados.Add(0);
        valoresPonderados.Add(0);

        string mensajeClienteMolesto = this.gameObject.transform.GetChild(0).GetComponent<Text>().text[0].ToString();
        Debug.Log("Cliente molesto: "+mensajeClienteMolesto);

        switch(mensajeClienteMolesto){
            case "1":
                valoresPonderados[0] = 0;
                valoresPonderados[1] = 0;
                valoresPonderados[2] = 0;
                valoresPonderados[3] = 0;
                valoresPonderados[4] = 0;
            break;
            case "2":
                valoresPonderados[0] = 5;
                valoresPonderados[1] = 4;
                valoresPonderados[2] = 5;
                valoresPonderados[3] = 5;
                valoresPonderados[4] = 5;
            break;
            case "3":
                valoresPonderados[0] = 5;
                valoresPonderados[1] = 5;
                valoresPonderados[2] = 4;
                valoresPonderados[3] = 3;
                valoresPonderados[4] = 5;
            break;
            case "4":
                valoresPonderados[0] = 0;
                valoresPonderados[1] = 0;
                valoresPonderados[2] = 0;
                valoresPonderados[3] = 0;
                valoresPonderados[4] = 0;
            break;                                        
        }        

        GameObject.Find("ControladorPrincipal").SendMessage("eleccionClienteMolesto", valoresPonderados);

    }


    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => evaluacionClienteMolesto());
    }

}

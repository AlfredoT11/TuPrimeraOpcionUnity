using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CambioEscenaJuego : MonoBehaviour
{
    
    void cambiarEscena(){
        SceneManager.LoadScene("AnalisisComportamiento");
    }

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => cambiarEscena());    
    }

}

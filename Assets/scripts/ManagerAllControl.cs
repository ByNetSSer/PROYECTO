using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ManagerAllControl : MonoBehaviour
{
    public Text Puntaje;
    public int contadorpoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Puntaje.text = "PUNTAJE:"+contadorpoints.ToString();
    }
}

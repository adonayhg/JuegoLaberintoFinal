using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using UnityEngine;

public class DetectorColisionPared : MonoBehaviour
{

[SerializeField]
    Material Pared;

[SerializeField]
    Material ParedChocada;

    bool paredRoja=false;
    float tiempoEnRojo = 5f;

    private void Update()
    {
        if (paredRoja == true)
        {
            tiempoEnRojo = tiempoEnRojo - Time.deltaTime;
            if ( tiempoEnRojo < 0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = Pared;
                paredRoja = false;
                tiempoEnRojo = 5f;
            }
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            Debug.Log(col.gameObject.name);
            gameObject.GetComponent<MeshRenderer>().material = ParedChocada;
            paredRoja=true;
        }
    }
}

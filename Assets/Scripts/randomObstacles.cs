using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomObstacles : MonoBehaviour
{
    int lastTrigger = 0;
    public GameObject obstaculo;
    GameObject clon;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int tiempoRedondeado = Mathf.FloorToInt(Time.time);
        if (tiempoRedondeado % 5 == 0 && tiempoRedondeado != lastTrigger)
        {
            int randPos = Random.Range(-3, 3);
            clon = Instantiate(obstaculo, transform.position, transform.rotation);
            clon.transform.Translate(0, 0, randPos);
        }
        if(tiempoRedondeado % 5 == 0)
        {
            lastTrigger = tiempoRedondeado;
            Debug.Log(lastTrigger);
        }
    }
}

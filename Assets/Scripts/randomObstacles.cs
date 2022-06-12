﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class randomObstacles : MonoBehaviour
{
    int lastTrigger = 1;
    public GameObject obstaculo;
    GameObject clon;
    public GameObject[] obstaculos = new GameObject[4];
    public Material[] materiales = new Material[4];
    void Start()
    {

    }
    void Update()
    {
        int randPos = Random.Range(-6, 7);
        int randObs = Random.Range(0, 4);
        int randMat = Random.Range(0, 4);
        int tiempoRedondeado = Mathf.FloorToInt(Time.time);
        if (tiempoRedondeado % 2 == 0 && tiempoRedondeado != lastTrigger)
        {
            // Debug.Log(randMat + " " + randObs);
            clon = Instantiate(obstaculos[randObs], transform.position, transform.rotation);
            if(randObs == 3)

            {
                clon.transform.Rotate(0,90,0);
            }
            clon.transform.Translate(0, 0, randPos);
            clon.GetComponent<MeshRenderer>().material = materiales[randMat];
        }
        if(tiempoRedondeado % 2 == 0)
        {
            lastTrigger = tiempoRedondeado;
            // Debug.Log(lastTrigger);
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject arbusto;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(arbusto.transform.position.x >= 30)
        {
            Instantiate(arbusto);
        }
    }
}

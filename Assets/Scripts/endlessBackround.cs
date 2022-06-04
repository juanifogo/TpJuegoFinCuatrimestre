using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endlessBackround : MonoBehaviour
{
    public float moveSpeed;
    public GameObject instanciaActual;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(moveSpeed, 0, 0);
        if(gameObject.transform.position.x >= 40)
        {
            Destroy(instanciaActual, 0.5f);

        }
    }
}

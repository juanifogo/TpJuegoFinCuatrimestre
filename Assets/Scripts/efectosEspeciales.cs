using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efectosEspeciales : MonoBehaviour
{
    public GameObject esfera;
    public Material[] materiales = new Material[3];
    public int cantInstancias;
    int randMatSFX;
    void Start()
    {
        if(PlayerController.state == "won")
        {
            for(int i=0; i<cantInstancias; i++)
            {
            randMatSFX = Random.Range(0,3);
            Instantiate(esfera, transform.position, transform.rotation);
            esfera.GetComponent<MeshRenderer>().material = materiales[randMatSFX];
            }
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

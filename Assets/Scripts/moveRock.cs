using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRock : MonoBehaviour
{
    public float rotateSpeed;
    void Start()
    {

    }
    void Update()
    {
        gameObject.transform.Rotate(rotateSpeed, 0, 0);
    }
}

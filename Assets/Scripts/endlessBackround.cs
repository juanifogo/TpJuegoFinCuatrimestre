using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endlessBackround : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(moveSpeed, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerExit(Collider gameArea)
    {
        if (gameArea.gameObject.tag == "gameArea")
        {
            transform.position += Vector3.right * -((gameArea.bounds.size.x) + GetComponent<BoxCollider>().size.x);
        }
    }
}

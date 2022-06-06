using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endlessObstacles : MonoBehaviour
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
    void OnTriggerExit(Collider ObstacleGameArea)
    {
        //transform.position += Vector3.right * -((ObstacleGameArea.bounds.size.x) + GetComponent<BoxCollider>().size.x);
        Destroy(gameObject, 1f);
    }
}

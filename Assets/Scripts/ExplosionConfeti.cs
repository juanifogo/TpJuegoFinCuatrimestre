using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionConfeti : MonoBehaviour
{
    public GameObject confeti;
    public Rigidbody rb;
    GameObject clon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.state == "won")
        {
            Physics.gravity = new Vector3(0f, -1f, 0f);
            Debug.Log("confeti");
            for(int i=0; i<50; i++)
            {
                int randPos = Random.Range(20, 551);
                clon = Instantiate(confeti, transform.position, transform.rotation);
                clon.transform.Translate(randPos, 0, 0);
            }
            Destroy(gameObject, 2f);
        }
    }
}

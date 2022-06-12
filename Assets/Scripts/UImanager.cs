using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UImanager : MonoBehaviour
{
    float time;
    int roundedTime;
    public Text instrucciones;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time = Time.time;
        roundedTime = Mathf.RoundToInt(time*100);
        if(roundedTime % 12 == 0)
        {
            Debug.Log(roundedTime);
            for(int i = 255; i>=0; i--)
            {
                Debug.Log(i);
                break;
    //            instrucciones.color = new Color(0,0,0,i);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymove1 : MonoBehaviour
{
    int counter = 0;
    float move = 0.025f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p= new Vector3(0,0,move);
        transform.Translate(p);
        counter++;  

        if(counter == 400)
        {
            transform.Rotate(new Vector3(0, 180, 0));
        }

        if (counter == 440)
        {
            transform.Rotate(new Vector3(0, 0, 0));
            counter = 0;
        }
    }
}
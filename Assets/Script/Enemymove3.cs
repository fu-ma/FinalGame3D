using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymove3 : MonoBehaviour
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
        Vector3 p = new Vector3(0, 0, move);
        transform.Translate(p);
        counter++;

        if (counter == 580)
        {
            transform.Rotate(new Vector3(0, 90, 0));
        }

        if (counter == 830)
        {
            transform.Rotate(new Vector3(0, 90, 0));
        }

        if (counter == 1410)
        {
            transform.Rotate(new Vector3(0, 90, 0));
        }

        if (counter == 1660)
        {
            transform.Rotate(new Vector3(0, 90, 0));
            counter = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymove2 : MonoBehaviour
{
    int counter = 0;
    float move = 0.025f;
    private publicFlag gameStop;

    // Start is called before the first frame update
    void Start()
    {
        gameStop = GameObject.Find("GameManager").GetComponent<publicFlag>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStop.stopFlag == false)
        {
            Vector3 p = new Vector3(0, 0, move);
            transform.Translate(p);
            counter++;
            if (counter == 400)
            {
                transform.Rotate(new Vector3(0, 90, 0));
            }

            if (counter == 600)
            {
                transform.Rotate(new Vector3(0, 90, 0));
            }

            if (counter == 1000)
            {
                transform.Rotate(new Vector3(0, 90, 0));
            }

            if (counter == 1200)
            {
                transform.Rotate(new Vector3(0, 90, 0));
                counter = 0;
            }
        }
    }
}
